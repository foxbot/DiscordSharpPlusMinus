using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace DiscordSharpPlusMinus.API
{
    internal class DiscordAPIClient
    {
        private const string BaseUrl = "https://discordapp.com/api/v6/";
        private readonly HttpClient _http;
        private readonly JsonSerializer _serializer;

        internal DiscordAPIClient(string token)
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri(BaseUrl);
            _http.DefaultRequestHeaders.Add("Authorization", token);
            _serializer = new JsonSerializer();
        }

        internal async Task Send(HttpRequestMessage request)
        {
            var response = await _http.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException(string.Concat(response.RequestMessage, "\n", await response.Content.ReadAsStringAsync()));
        }
        internal async Task<T> Send<T>(HttpRequestMessage request)
        {
            var response = await _http.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException(string.Concat(response.RequestMessage, "\n", response.Content));
            return _serializer.Deserialize<T>(new JsonTextReader(new StreamReader(await response.Content.ReadAsStreamAsync())));
        }

        internal async Task<Message> CreateMessageAsync(ulong channel, string content)
        {
            var endpoint = $"channels/{channel}/messages";
            var req = new HttpRequestMessage(HttpMethod.Post, endpoint);
            req.Content = new StringContent(JsonConvert.SerializeObject(new { content = content }));
            req.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            return await Send<Message>(req);
        }

        internal async Task<Channel> GetChannelAsync(ulong id)
        {
            var endpoint = $"channels/{id}";
            var req = new HttpRequestMessage(HttpMethod.Get, endpoint);
            return await Send<Channel>(req);
        }
    }
}
