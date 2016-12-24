using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordSharpPlusMinus
{
    public class DiscordPartyClient
    {
        internal readonly API.DiscordAPIClient api;

        /// <summary>
        /// make a party client :)
        /// </summary>
        /// <param name="token">your token !!!!!must!!!!! start with 'Bot ' if its a bot account</param>
        public DiscordPartyClient(string token)
        {
            api = new API.DiscordAPIClient(token);
        }

        internal Channel GetChannel(ulong id)
        {
            var c = api.GetChannelAsync(id).GetAwaiter().GetResult();
            c.Discord = this;
            return c;
        }

        public static Channel operator ^(DiscordPartyClient party, ulong id)
        {
            return party.GetChannel(id);
        }
    }
}
