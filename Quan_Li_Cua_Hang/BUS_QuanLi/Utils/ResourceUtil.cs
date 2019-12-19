using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLi.Utils
{
    public static class ResourceUtil
    {

        public static String CopyToResource(String filePath, String _default = "Resources/MonAn/Default.jpg")
        {
            if (!File.Exists(filePath)) return _default;
            Directory.CreateDirectory("Resources/MonAn");
            String fileName = Path.GetRandomFileName() + Path.GetExtension(filePath);
            while (File.Exists(fileName))
                fileName = Path.GetRandomFileName() + Path.GetExtension(filePath);
            String newPath = Path.Combine("Resources/MonAn", fileName);
            new Task(() => File.Copy(filePath, newPath)).Start();
            return newPath;
        }
    }
}
