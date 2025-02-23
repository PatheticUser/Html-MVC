using System.ComponentModel.DataAnnotations;

namespace Neuronix_Labs.Models
{
    public class Article
    {
        [Key] // Explicitly marking it as Primary Key
        public int ArticleId { get; set; }  // Rename Id to ArticleId

        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }

}
