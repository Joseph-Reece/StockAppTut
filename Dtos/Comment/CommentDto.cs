using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
    }
}