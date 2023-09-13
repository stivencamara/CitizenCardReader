using CCR.Extensions;
using CCR.Models;
using CSJ2K;
using eidpt;
using pt.portugal.eid;
using System.Collections;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CCR
{
    public class CardReader
    {
        public CardReader()
        {
            Pteid.Init(null);
            Pteid.SetSODChecking(0);
        }

        public PTEID_ReaderContext Context
        {
            get;
            private set;
        }

        public Citizen Read()
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
                BirthDate = iD.birthDate
            };

            ReadPicture(citizen);

            return citizen;
        }

        private PTEID_EIDCard GetInstance()
        {
            PTEID_ReaderSet pTEID_ReaderSet = PTEID_ReaderSet.instance();
            Context = pTEID_ReaderSet.getReader();
            return Context.getEIDCard();
        }

        private void ReadPicture(Citizen citizen)
        {
            var pic = Pteid.GetPic();

            if (pic != null && pic.picture != null)
            {
                try
                {
                    using (MemoryStream stream = new MemoryStream(pic.picture))
                    {
                        using (Bitmap bitmap = new Bitmap(stream))
                        {
                            // Salvar o bitmap como um arquivo PNG
                            bitmap.Save("C:\\teste.png", System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao converter byte[] em PNG: " + ex.Message);
                }

                var value = J2kImage.FromBytes(pic.picture).As<Bitmap>();
                byte[] inArray = (byte[])new ImageConverter().ConvertTo(value, typeof(byte[]));
                citizen.Picture = Convert.ToBase64String(inArray);
            }
        }


        private X509Certificate2Collection GetCertificates()
        {
            X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
            PteidCertif[] certificates = Pteid.GetCertificates();
            if (certificates == null)
            {
                return x509Certificate2Collection;
            }
            PteidCertif[] array = certificates;
            for (int i = 0; i < array.Length; i++)
            {
                X509Certificate2 certificate = new X509Certificate2(array[i].certif);
                x509Certificate2Collection.Add(certificate);
            }
            return x509Certificate2Collection;
        }
    }
}
