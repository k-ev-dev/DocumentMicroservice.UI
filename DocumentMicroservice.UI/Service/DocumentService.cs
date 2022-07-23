using DocumentMicroservice.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DocumentMicroservice.UI.Service {
    public class DocumentService : IDocumentService {

        private readonly HttpClient httpClient = new HttpClient();

        public DocumentService(HttpClient http) {
            this.httpClient = http;
        }

        public async Task<Document> CreateNewDocument(Document request, string uri) {
            var result = await httpClient.PostAsJsonAsync(uri, request);
            return await result.Content.ReadFromJsonAsync<Document>();
        }

        public async Task<IReadOnlyList<Document>> GetAllDocs(string uri) {
            return await httpClient.GetFromJsonAsync<IReadOnlyList<Document>>(uri);
        }

        public async Task<Document> GetDocById(string uri) {
            return await httpClient.GetFromJsonAsync<Document>(uri);
        }

        public async Task<Document> PutDocument(Document request, string uri) {
            var result = await httpClient.PutAsJsonAsync(uri, request);
            return await result.Content.ReadFromJsonAsync<Document>();
        }

        public async Task<String> DeleteDocument(string uri) {
            var result =  await httpClient.DeleteAsync(uri);
            return await result.Content.ReadAsStringAsync();
        }
    }
}
