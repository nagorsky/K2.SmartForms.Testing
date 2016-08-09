using K2Smartforms.TestingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            testSuite testInst = new testSuite("MDM.IT.SoftwareChange");

            testInst.Run("CreateRequestAndAllApprove");
            testInst.RunTest("ApproveBPOwner");

        }
    }
}
