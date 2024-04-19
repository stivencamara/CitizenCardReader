using CCR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCSC;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CCRTest
{
    [TestClass]
    public class CardReaderTest
    {
        [TestMethod]
        public void CanShould_ReadCitizen()
        {
            //var cardReader = new CardReader();

            //var citizen = cardReader.Read();

            //Assert.IsNotNull(citizen);
        }

        [TestMethod]
        public void CanShould_SignMutipleDocuments()
        {
            var sample1Path = Path.Combine(Environment.CurrentDirectory, "Files", "Sample1.pdf");
            var sample2Path = Path.Combine(Environment.CurrentDirectory, "Files", "Sample2.pdf");

            new CartaoCidadaoSigner().Sign(new string[2]{
            sample1Path,
            sample2Path
            }, "c:\\output", 1, 2, "Montijo", "Teste");

            //cardReader.SignDocument(sample1Path, sample1Path.Replace(".pdf", "-signed.pdf"), 1, 100, "Montijo", "Teste");
        }

        [TestMethod]
        public void CanShould_SignSingleDocument()
        {
            var sample1Path = Path.Combine(Environment.CurrentDirectory, "Files", "Sample1.pdf");

            new CartaoCidadaoSigner().Sign(sample1Path, sample1Path.Replace(".pdf", "-signed.pdf"), 1, 100, "Montijo", "Teste");
        }


        SerialPort serialPort;

        [TestMethod]
        public void CanShould_SignMultipleDocument()
        {
            var monitor = new CardReaderMonitor();

            monitor.StatusChange += Monitor_StatusChange;

            monitor.Start();
        }

        [TestMethod]
        public void afsd()
        {
            X509Store certStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            certStore.Open(OpenFlags.ReadOnly);

            X509Certificate2 certificado = certStore.Certificates.Cast<X509Certificate2>().First();

            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)certificado.PublicKey.Key;

            // Converta o texto em bytes
            byte[] textoBytes = Encoding.UTF8.GetBytes("Stiven");

            // Criptografe os dados com a chave pública
            byte[] dadosCriptografados = rsa.Encrypt(textoBytes, false);

            // Converta o resultado em base64
            string resultadoBase64 = Convert.ToBase64String(dadosCriptografados);
        }

        private void Monitor_StatusChange(object sender, CardReaderStatusChangeEventArgs e)
        {
            if(e.Status == CardReaderStatusChange.CardRemoved || e.Status == CardReaderStatusChange.CardInserted)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
