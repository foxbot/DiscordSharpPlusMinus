using System;
using Newtonsoft.Json;

// Copyright Warning !! I am not copying this from Discord.Net but i have the file open on the other monitor
// Thanks Voltana :) always on bus smh

namespace DiscordSharpPlusMinus
{
    public class Message
    {
        [JsonProperty("id")] public ulong Id { get; internal set; }
        [JsonProperty("type")] public MessageType Type { get; internal set; }
        [JsonProperty("channel_id")] public ulong ChannelId { get; internal set; }
        [JsonProperty("webhook_id")] public ulong WebhookId { get; internal set; }
        [JsonProperty("author")] public User Author { get; internal set; }
        [JsonProperty("content")] public string Content { get; internal set; }
        [JsonProperty("timestamp")] public DateTimeOffset Timestamp { get; internal set; }
        [JsonProperty("edited_timestamp")] public DateTimeOffset EditedTimestamp { get; internal set; }
        [JsonProperty("tts")] public bool IsTextToSpeech { get; internal set; }
        [JsonProperty("mention_everyone")] public bool MentionEveryone { get; internal set; }
        [JsonProperty("mentions")] public User[] UserMentions { get; internal set; }
        [JsonProperty("mention_roles")] public ulong[] RoleMentions { get; internal set; }
        [JsonProperty("pinned")] public bool Pinned { get; internal set; }
    }
}