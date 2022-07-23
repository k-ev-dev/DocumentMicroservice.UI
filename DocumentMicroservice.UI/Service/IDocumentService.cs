using DocumentMicroservice.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentMicroservice.UI.Service {
    public interface IDocumentService {

        Task<Document> CreateNewDocument(Document request, string uri);
        Task<IReadOnlyList<Document>> GetAllDocs(string uri);
        Task<Document> GetDocById(string uri);
        Task<Document> PutDocument(Document request, string uri);
        Task<String> DeleteDocument(string uri);
    }
}
