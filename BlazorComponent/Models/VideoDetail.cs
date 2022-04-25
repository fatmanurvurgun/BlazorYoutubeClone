using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Models
{
    public class VideoDetail
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public List<string> Comments { get; set; } = new List<string>();
    }
}
