using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QuanLi.Utils
{
    public static class ResourceUtil
    {

        public static String CopyToResource(String filePath)
        {
            Directory.CreateDirectory("Resource");
            String fileName = Path.GetRandomFileName() + Path.GetExtension(filePath);
            while (File.Exists(fileName))
                fileName = Path.GetRandomFileName() + Path.GetExtension(filePath);
            String newPath = Path.Combine("Resource", fileName);
            new Task(() => File.Copy(filePath, newPath)).Start();
            return newPath;
        }
    }
}
