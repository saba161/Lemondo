using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lemondo.UI.Extentions
{
    public static class HttpClientExtentions
    {
        public static async Task<List<T>> GetListAsync<T>(this HttpClient _client, string url)
        {
            var response = await _client.GetAsync(url);
            if (!response.IsSuccessStatusCode) throw new Exception("todo make normalize error");
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<T>>(data);
        }
    }
}