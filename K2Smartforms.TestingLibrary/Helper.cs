using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace K2Smartforms.TestingLibrary
{
    public static class Helper
    {


        public static string getCurrFolderPath() {

            return System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        }
        public static string AppFolderCreator(string folderName)
        {
            var targetPath = Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(getCurrFolderPath()).ToString()).ToString()).ToString(), folderName);

            bool exists = System.IO.Directory.Exists(targetPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(targetPath);

            }

            return targetPath;
        }
    }
}
