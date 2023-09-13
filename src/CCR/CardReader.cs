using CCR.Models;
using CSJ2K;
using CSJ2K.Util;
using eidpt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CCR
{
    public class CardReader
    {
        public CardReader()
        {
            Pteid.Init(null);
            Pteid.SetSODChecking(0);
        }

        /// <summary>
        /// Read the information on your citizen card
        /// </summary>
        /// <param name="includeAddress">If true, will need to provide your address pin</param>
        /// <returns></returns>
        public Citizen Read(bool includeAddress = false)
        {
            PteidId iD = Pteid.GetID();

            var citizen = new Citizen
            {
                Number = iD.cardNumber,
                BI = iD.numBI,
                Nationality = iD.nationality,
                Genre = iD.sex,
                Country = iD.country,
                SNS = iD.numSNS,
                NIF = iD.numNIF,
                Name = iD.name,
                FirstName = iD.firstname,
                ExpirationDate = iD.validityDate,
                BirthDate = iD.birthDate,
                Height = iD.height,
                DocumentType = iD.documentType,
                Notes = iD.notes,
                SS = iD.numSS                
            };

            if (includeAddress)
                ReadAddress(citizen);

            ReadPicture(citizen);
            ReadCertificates(citizen);

            return citizen;
        }

        private void ReadAddress(Citizen citizen)
        {
            PteidAddr addr = Pteid.GetAddr();

            citizen.Address.Street = addr.street;
            citizen.Address.District = addr.districtDesc;
            citizen.Address.Building = addr.building;
            citizen.Address.Country = addr.country;
            citizen.Address.Type = addr.addrType;
            citizen.Address.Parish = addr.freguesiaDesc;
            citizen.Address.Locality = addr.locality;
            citizen.Address.Door = addr.door;
            citizen.Address.Floor = addr.floor;
            citizen.Address.ZipCode1 = addr.cp4;
            citizen.Address.ZipCode2 = addr.cp3;
            citizen.Address.StreetType = addr.streettype;
            citizen.Address.Postal = addr.postal;
            citizen.Address.Municipality = addr.municipality;
            citizen.Address.Side = addr.side;
            citizen.Address.Place = addr.place;
        }

        private void ReadPicture(Citizen citizen)
        {
            BitmapImageCreator.Register();

            var pic = Pteid.GetPic();

            if (pic != null && pic.picture != null)
            {
                var value = J2kImage.FromBytes(pic.picture).As<Bitmap>();
                byte[] inArray = (byte[])new ImageConverter().ConvertTo(value, typeof(byte[]));
                citizen.Picture = Convert.ToBase64String(inArray);
            }
        }

        private void ReadCertificates(Citizen citizen)
        {
            PteidCertif[] certificates = Pteid.GetCertificates();

            if (certificates != null)
            {
                List<Certificate> list = new List<Certificate>();
                PteidCertif[] array = certificates;

                foreach (PteidCertif pteidCertif in array)
                {
                    X509Certificate2 x509Certificate = new X509Certificate2(pteidCertif.certif);

                    var expirationDateString = x509Certificate.GetExpirationDateString();

                    list.Add(new Certificate
                    {
                        Label = pteidCertif.certifLabel,
                        ExpirationDateString = expirationDateString,
                        KeyAlgorithm = x509Certificate.GetKeyAlgorithm(),
                        PublicKey = x509Certificate.GetPublicKeyString()
                    });
                }

                citizen.Certificates = list;
            }
        }

        private X509Certificate2[] GetCertificates()
        {
            X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
            PteidCertif[] certificates = Pteid.GetCertificates();
            if (certificates == null)
            {
                return x509Certificate2Collection.Cast<X509Certificate2>().ToArray();
            }
            PteidCertif[] array = certificates;
            for (int i = 0; i < array.Length; i++)
            {
                X509Certificate2 certificate = new X509Certificate2(array[i].certif);
                x509Certificate2Collection.Add(certificate);
            }
            return x509Certificate2Collection.Cast<X509Certificate2>().ToArray();
        }
    }
}
