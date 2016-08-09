using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class Helper
    {


        public static string getCurrFolderPath() {

            return System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        }
        public static string AppFolderCreator(string folderName)
        {
            var targetPath = System.IO.Path.Combine(getCurrFolderPath(), folderName);

            bool exists = System.IO.Directory.Exists(targetPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(targetPath);

            }

            return targetPath;
        }
    }
}
