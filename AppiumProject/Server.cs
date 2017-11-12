using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlutoSolutionsAppium
{
    public class AppiumServer
    {
        private Process process = null;
        private  string Address = "127.0.0.1";
        private string Port = "5000";

        public void Start()
        {
            process = new Process();
            process.StartInfo.FileName = "appium.cmd";
            process.StartInfo.WorkingDirectory = "C:\\Appium\\node_modules\\.bin";
            process.StartInfo.Arguments = "--address 127.0.0.1 --port 5000";
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit();

            //process.StartInfo.FileName = "notepad.exe";
            //process.StartInfo.WorkingDirectory = "c:\\";
            //process.StartInfo.Arguments = "somefile.txt";
            //process.StartInfo.CreateNoWindow = false;
            //process.Start();
            //process.WaitForExit();
        }

        public void Stop()
        {
            process.Close();
        }
    }
}
