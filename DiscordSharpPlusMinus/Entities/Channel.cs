using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

// copy right !! shout out voltana

namespace DiscordSharpPlusMinus
{
    public class Channel
    {
        [JsonProperty("id")] public ulong Id { get; internal set; }
        [JsonProperty("type")] public ChannelType Type { get; internal set; }
        [JsonProperty("name")] public string Name { get; internal set; }
        [JsonProperty("position")] public int Position { get; internal set; }
        [JsonProperty("topic")] public string Topic { get; internal set; }

        internal DiscordPartyClient Discord { get; set; }

        internal Message SendMessage(string content)
        {
            return Discord.api.CreateMessageAsync(Id, content).GetAwaiter().GetResult();
        }

        public static Message operator +(Channel left, string content)
        {
            return left.SendMessage(content);
        }
    }
}
