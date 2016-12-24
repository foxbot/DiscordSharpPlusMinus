using System;
using DiscordSharpPlusMinus;

class Program
{
    static void Main(string[] args)
    {
        new Program().Yes();
    }

    // i have done a great good :)
    public void Yes()
    {
        var token = string.Concat("Bot ", Environment.GetEnvironmentVariable("discord-foxboat-token"));
        var client = new DiscordPartyClient(token);
        var channel = client ^ 81384788765712384;
        var message = channel + "hi there Dude :) SMACK SUB BUTTON!!!!! https://www.youtube.com/channel/UCpZdUIxqwnwxvIEmaa1kPqA";
        Console.Read();
    }
}
