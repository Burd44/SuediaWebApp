using System.ComponentModel.DataAnnotations;

namespace SuediaWebApp.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Article()
        {

        }
    }
}
