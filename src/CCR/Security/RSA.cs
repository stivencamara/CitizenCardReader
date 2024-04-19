using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CCR.Security
{
    public class RSA
    {
        public static string Encrypt(X509Certificate2 certificate, string clearText)
        {
            using (RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)certificate.PublicKey.Key)
            { 
                byte[] byteText = Encoding.UTF8.GetBytes(clearText);
                byte[] byteEntry = rsa.Encrypt(byteText, false);

                return Convert.ToBase64String(byteEntry);
            }
        }

        public static string Encrypt(string xmlString, string clearText)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(xmlString);

                byte[] byteText = Encoding.UTF8.GetBytes(clearText);
                byte[] byteEntry = rsa.Encrypt(byteText, false);

                return Convert.ToBase64String(byteEntry);
            }
        }
    }
}
