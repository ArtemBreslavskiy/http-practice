using ConsoleApp21.Dto;
using http_practice.Dto;
using http_practice.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace http_practice.Services
{
    internal class UserServices
    {
        private readonly HttpClient _http;

        public UserServices()
        {
            _http = ApiClient.Instance;
        }

        public async Task<List<CommentDto>> GetAllAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<CommentDto>>("/api/comments");
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

        public async Task<HttpResponce> Create(CommentDto comment)
        {
            try
            {
                return await _http.PostAsJsonAsync(comment);
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

        public async Task<HttpResponce> CreateAsync(CommentDto comment)
        {
            try
            {
                return await _http.PutAsJsonAsync<CommentDto>("/api/posts", comment);
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