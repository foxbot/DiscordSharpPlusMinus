using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

// copy right warning !! i am getting tired of typing so im gonna start copying now
// bless voltana ;0

namespace DiscordSharpPlusMinus
{
    public class User
    {
        [JsonProperty("id")] public ulong Id { get; internal set; }
        [JsonProperty("username")] public string Username { get; internal set; }
        [JsonProperty("discriminator")] public string Discriminator { get; internal set; }
        [JsonProperty("bot")] public bool Bot { get; internal set; }
        [JsonProperty("avatar")] public string Avatar { get; internal set; }
    }
}
