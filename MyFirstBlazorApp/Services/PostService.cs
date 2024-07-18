using MyFirstBlazorApp.Models;
using System.Net.Http.Json;

namespace MyFirstBlazorApp.Services
{
    public class PostService
    {
        private readonly HttpClient _httpClient;

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Post[]> GetPostsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Post[]>("https://jsonplaceholder.typicode.com/posts");
        }
    }
}
