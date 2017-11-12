using System;

namespace PlutoSolutionsAppium.Server
{
    public class Server
    {
        private string host = String.Empty;
        private string port = String.Empty;

        public string Host { get { return host; } }
        public string Port { get { return port; } }

        public Server(string Host, string Port)
        {
            this.host = Host;
            this.port = Port;
        }
    }
}
