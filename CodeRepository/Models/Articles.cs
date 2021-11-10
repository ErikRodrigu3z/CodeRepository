using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRepository.Models
{
    public class Articles
    {
        public int IdArticle { get; set; }
        public string Content { get; set; }
        public string Title { get; set; } 
        public int IdCategory { get; set; }
        public DateTime Date { get; set; } 

    }
}
