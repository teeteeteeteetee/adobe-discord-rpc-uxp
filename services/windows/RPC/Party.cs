using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeDiscordRPCService.RPC
{
    internal class Party
    {
        public Party(int ID, int players, int maxPlayers)
        {
            this.ID = ID;
            Players = players;
            MaxPlayers = maxPlayers;
        }

        public int ID { get; }
        public int Players { get; }
        public int MaxPlayers { get; }
    }
}
