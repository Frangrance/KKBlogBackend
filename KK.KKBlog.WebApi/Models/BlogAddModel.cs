using Microsoft.AspNetCore.Http;

namespace KK.KKBlog.WebApi.Models
{
    public class BlogAddModel
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }
        public int AppUserId { get; set; }
    }
}
