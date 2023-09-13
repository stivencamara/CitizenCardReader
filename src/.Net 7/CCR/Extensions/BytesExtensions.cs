using System.Drawing;

namespace CCR.Extensions
{
    public static class BytesExtensions
    {
        public static byte[] ReadBinary(this string filePath)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    return memoryStream.ToArray();
                }
            }
        }

        public static Bitmap ToBitmap(this byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                return new Bitmap(stream);
            }
        }
    }
}

