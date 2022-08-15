using AdobeDiscordRPCService.RPC;
using AdobeDiscordRPCService.WebSockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AdobeDiscordRPCService
{
    public partial class Service1 : ServiceBase
    {

        List<Client> clients = new List<Client>();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // start websocket server and wait for connections
            new Server();
        }

        protected override void OnStop()
        {
            foreach (var client in clients)
            {
                client.Destroy();
            }
        }
    }
}
