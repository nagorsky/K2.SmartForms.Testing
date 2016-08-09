using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Smartforms.TestingLibrary
{
    public class Settings
    {
        public Settings()
        {
            dictionary = new Dictionary<string, string>();
        }

        public string baseUrl { get; set; }
        public string speed { get; set; }
        public string screenshotMode { get; set; }
        public string screenshotFolder { get; set; }
        public string ignoreErrorMode { get; set; }
        public int delayBetweenStepsSec { get; set; }
        public  Dictionary<string, string> dictionary { get; set; }

    }
}
