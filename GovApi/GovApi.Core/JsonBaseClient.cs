using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GovApi.Core.Models;

namespace GovApi.Core
{
    public class JsonBaseClient : IDisposable
    {
        protected readonly HttpClient HTTPClient;

        protected JsonBaseClient(string baseUrl)
        {
            HTTPClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            HTTPClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected async Task<string> PostAsync(string url, HttpContent content)
        {
            var responseMessage = await HTTPClient.PostAsync(url, content);
            return await VerifySuccessAsync(responseMessage);
        }

        protected async Task<string> GetAsync(string url)
        {
            var responseMessage = await HTTPClient.GetAsync(url);
            return await VerifySuccessAsync(responseMessage);
        }

        private static async Task<string> VerifySuccessAsync(HttpResponseMessage responseMessage)
        {
            if (responseMessage.Content == null) throw new SimpleHttpResponseException(responseMessage.StatusCode, "No content");

            var content = await responseMessage.Content.ReadAsStringAsync();
            if (responseMessage.IsSuccessStatusCode) return content;

            responseMessage.Content.Dispose();

            throw new SimpleHttpResponseException(responseMessage.StatusCode, content);
        }

        public void Dispose()
        {
            HTTPClient?.Dispose();
        }
    }
}
