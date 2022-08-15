using AdobeDiscordRPCService.RPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Net;

namespace AdobeDiscordRPCService.WebSockets
{

    internal class Server
    {
        HttpListener httpListener = new HttpListener();
        public Server(int port = 12001)
        {
            httpListener.Prefixes.Add($"http://localhost:{port}/");
        }
        public async Task Start()
        {
            httpListener.Start();
            HttpListenerContext context = await httpListener.GetContextAsync();
            if (context.Request.IsWebSocketRequest)
            {
                HttpListenerWebSocketContext webSocketContext = await context.AcceptWebSocketAsync(null);
                var webSocket = webSocketContext.WebSocket;
                
                while (webSocket.State == WebSocketState.Open)
                {
                    //await webSocket.SendAsync();
                }
            }
        }

    }
}
