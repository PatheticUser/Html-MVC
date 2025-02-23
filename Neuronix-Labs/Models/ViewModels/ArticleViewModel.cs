using System.Collections.Generic;
using Neuronix_Labs.Models; // Ensure it matches your models' namespace

namespace Neuronix_Labs.Models.ViewModels // Matches folder structure
{
    public class ArticleViewModel
    {
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}



