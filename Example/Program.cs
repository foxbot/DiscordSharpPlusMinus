using System;
using DiscordSharpPlusMinus;

class Program
{
    static void Main(string[] args)
    {
        new Program().Yes();
    }

    public void Yes()
    {
        var token = string.Concat("Bot ", Environment.GetEnvironmentVariable("discord-foxboat-token"));
        var client = new DiscordPartyClient(token);
        var channel = client ^ 81384788765712384;
        var message = channel + "ok it is ready";
        Console.Read();
    }
}