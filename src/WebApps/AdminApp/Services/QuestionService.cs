using AdminApp.Services.Interfaces;
using Examination.Shared.Questions;
using Examination.Shared.SeedWork;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AdminApp.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly HttpClient _httpClient;
        public QuestionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateAsync(CreateQuestionRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/v1/categories", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var result = await _httpClient.DeleteAsync($"/api/v1/categories/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<PagedList<QuestionDto>> GetQuestionPagingAsync(QuestionSearch questionSearch)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageIndex"] = questionSearch.PageNumber.ToString(),
                ["pageSize"] = questionSearch.PageSize.ToString()
            };

            if (!string.IsNullOrEmpty(questionSearch.Name))
                queryStringParam.Add("searchKeyword", questionSearch.Name);


            string url = QueryHelpers.AddQueryString("/api/v1/questions", queryStringParam);

            var result = await _httpClient.GetFromJsonAsync<PagedList<QuestionDto>>(url);
            return result;
        }

        public async Task<QuestionDto> GetQuestionByIdAsync(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<QuestionDto>($"/api/v1/categories/{id}");
            return result;
        }

        public async Task<bool> UpdateAsync(UpdateQuestionRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/v1/categories", request);
            return result.IsSuccessStatusCode;
        }
    }
}
