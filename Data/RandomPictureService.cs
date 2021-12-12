using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace CS401_Final_Blazor.Data
{
    public class RandomPictureService
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _httpClient;
        public RandomPictureService(IConfiguration config)
        {
            _config = config;
            _httpClient = new HttpClient();
        }
        public async Task<RandomPictureModel> GetRandomPictureAsync()
        {
            string accessKey = _config["RandomPictureAccessKey"];
            string endpoint = $"https://api.unsplash.com/photos/random";
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Client-ID {accessKey}");
            string response = await _httpClient.GetStringAsync(endpoint);
            RandomPictureModel model = JsonSerializer.Deserialize<RandomPictureModel>(response);
            return model;
        }
    }
}
