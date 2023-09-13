using CCR.Extensions;
using CCR.Services;

namespace CCR.Tests
{
    [TestClass]
    public class SignTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var service = new CCRService();

            var path = Path.Combine(Environment.CurrentDirectory, "Files", "Sample1.pdf");

            service.Sign(new Models.File
            {
                Path = path,
                Bytes = path.ReadBinary(),
                Id = Guid.NewGuid().ToString(),
                Name = new FileInfo(path).Name
            });
        }
    }
}