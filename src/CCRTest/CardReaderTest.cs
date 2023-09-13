using CCR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCSC;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Management;

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
            //using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            //{
            //    var readerNames = context.GetReaders();

            //    if (readerNames == null || readerNames.Length == 0)
            //    {
            //        Console.WriteLine("Nenhum leitor de smart card encontrado.");
            //        return;
            //    }

            //    Console.WriteLine("Leitores de smart card disponíveis:");
            //    foreach (var readerName1 in readerNames)
            //    {
            //        Console.WriteLine(readerName1);
            //    }

            //    var readerName = readerNames[0]; // Escolha o leitor de smart card que você deseja verificar

            //    using (var reader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1))
            //    {
            //        var state = reader.GetStatus();

            //        if (state.State == SCardState.Present)
            //        {
            //            Console.WriteLine($"Cartão presente no leitor {readerName}.");
            //        }
            //        else if (state.State == SCardState.Unknown)
            //        {
            //            Console.WriteLine($"Nenhum cartão no leitor {readerName}.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Estado desconhecido no leitor {readerName}.");
            //        }
            //    }
            //}

            //Console.WriteLine("Pressione Enter para sair.");
            //Console.ReadLine();
        }

    }
}
