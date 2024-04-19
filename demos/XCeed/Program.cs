using System.Reflection;
using Xceed.Words.NET;

namespace XCeed
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string DocumentOutputFileName = @"PedidoAcesso.docx";

        Xceed.Words.NET.Licenser.LicenseKey = "WDN21-TM44B-H4UFD-1XZA";

            var pathTemplate = Utils.GetTemplatePath(DocumentOutputFileName);
            var pathOutput = Utils.GetOutPutPath($"{Guid.NewGuid()}.docx");

            try
            {
                using (var document = DocX.Load(pathTemplate))
                {
                    document.ReplaceText("<DATA>", DateTime.Now.ToString());



                    document.SaveAs(pathOutput);
                    pathOutput = pathOutput.Replace(".docx", "") + ".pdf";

                    DocX.ConvertToPdf(document, pathOutput);

                }

            }
            catch (Exception e)
            {
                throw;
            }

            var f = File.ReadAllBytes(pathOutput);
        }
    }
}