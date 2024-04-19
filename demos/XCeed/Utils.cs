
namespace XCeed
{
    public static class Utils
    {
        public static string GetRootPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;

            //return Path.Combine(Environment.CurrentDirectory, "bin", "Debug", "net5.0");
        }

        public static string GetPath(string folderName)
        {
            var path = Path.Combine(GetRootPath(), folderName);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path;
        }

        public static string GetOutPutPath()
        {
            return GetPath("Output");
        }
        public static string GetOutPutPath(string fileName)
        {

            return Path.Combine(GetOutPutPath(), fileName);
        }

        public static string GetTemplatePath()
        {
            return GetPath("Templates");
        }

        public static string GetTemplatePath(string fileName)
        {
            return Path.Combine(GetTemplatePath(), fileName);
        }
    }
}
