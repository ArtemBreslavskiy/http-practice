using http_practice.Dto;
using http_practice.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp21.Services
{
    internal class CommentServices
    {
        private readonly HttpClient _http;

        public CommentServices()
        {
            _http = ApiClient.Instance;
        }

        public async Task<List<PostDto>> GetAllAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<PostDto>>("/api/posts");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error HTTP request: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error get all users: {ex.Message}");
                throw;
            }
        }
    }
}
