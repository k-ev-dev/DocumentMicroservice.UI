using System.ComponentModel.DataAnnotations;

namespace DocumentMicroservice.UI.Model {
    public class Document {
        public Guid Id { get; set; }
        // TODO: добавить атрибуты
        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;
    }
}
