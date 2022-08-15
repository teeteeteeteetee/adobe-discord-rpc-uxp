using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace AdobeDiscordRPCService.RPC
{
    internal class Client
    {
        private DiscordRpcClient client;

        public Client(string appId)
        {
            client = new DiscordRpcClient(appId);
        }

        public void SetPresence(RichPresence presence)
        {
            client?.SetPresence(presence);
        }

        public void Update()
        {
            client.Invoke();
        }
        
        public Boolean Login()
        {
            client?.Initialize();
            return true;
        }

        public void Destroy()
        {
            client?.Dispose();
        }




    }
}
