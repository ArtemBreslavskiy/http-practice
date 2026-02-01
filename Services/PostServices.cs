using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using http_practice.Dto;
using http_practice.Infrastructure;

namespace http_practice.Services
{
    internal class PostService
    {
        private readonly HttpClient _http;

        public PostService()
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