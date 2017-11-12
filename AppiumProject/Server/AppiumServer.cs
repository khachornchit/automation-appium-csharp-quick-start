using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlutoSolutionsAppium.Server
{
    public class AppiumServer
    {
        private Server server;
        private Process process = null;
        private string workDirectory = @"C:\Appium\node_modules\.bin";
        private string fileName = "appium.cmd";

        public string Host
        {
            get { return server.Host; }
        }

        public string Port
        {
            get { return server.Port; }
        }

        public void StartServer()
        {
            server = TestServers.Server;
            StartProcess();
        }

        public void StartServer1()
        {
            server = TestServers.Server1;
            StartProcess();
        }

        public void StartServer2()
        {
            server = TestServers.Server2;
            StartProcess();
        }

        public void StartServer3()
        {
            server = TestServers.Server3;
            StartProcess();
        }

        public void StartServer4()
        {
            server = TestServers.Server4;
            StartProcess();
        }

        public void StartServer5()
        {
            server = TestServers.Server5;
            StartProcess();
        }

        public void StartServer6()
        {
            server = TestServers.Server6;
            StartProcess();
        }

        public void StartServer7()
        {
            server = TestServers.Server7;
            StartProcess();
        }

        public void StartServer8()
        {
            server = TestServers.Server8;
            StartProcess();
        }

        public void StartServer9()
        {
            server = TestServers.Server9;
            StartProcess();
        }
        
        private void StartProcess()
        {
            process = new Process();
            process.StartInfo.WorkingDirectory = workDirectory;
            process.StartInfo.FileName = fileName;
            process.StartInfo.Arguments = string.Format("--address {0} --port {1}", server.Host, server.Port);
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            System.Threading.Thread.Sleep(5000);
        }

        public void Stop()
        { 
            CloseWindow();
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(uint dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate handler, bool add);

        // Delegate type to be used as the Handler Routine for SCCH
        delegate Boolean ConsoleCtrlDelegate(CtrlTypes type);

        // Enumerated type for the control messages sent to the handler routine
        enum CtrlTypes : uint
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GenerateConsoleCtrlEvent(CtrlTypes dwCtrlEvent, uint dwProcessGroupId);

        public static void StopProgram(uint pid)
        {
            // It's impossible to be attached to 2 consoles at the same time,
            // so release the current one.
            FreeConsole();

            // This does not require the console window to be visible.
            if (AttachConsole(pid))
            {
                // Disable Ctrl-C handling for our program
                SetConsoleCtrlHandler(null, true);
                GenerateConsoleCtrlEvent(CtrlTypes.CTRL_C_EVENT, 0);

                // Must wait here. If we don't and re-enable Ctrl-C
                // handling below too fast, we might terminate ourselves.
                Thread.Sleep(2000);

                FreeConsole();

                // Re-enable Ctrl-C handling or any subsequently started
                // programs will inherit the disabled state.
                SetConsoleCtrlHandler(null, false);
            }
        }

        private void CloseWindow()
        {
            // retrieve the handler of the window  
            int iHandle = (int)process.MainWindowHandle;
            if (iHandle > 0)
            {
                // close the window using API        
                SendMessage(iHandle, WM_SYSCOMMAND, SC_CLOSE, 0);
            }
        }
    }
}
