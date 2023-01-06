using FirstASPwebsite.Models;
using FirstASPwebsite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstASPwebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFilePostService PostService;
        public IEnumerable<Post> Posts { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFilePostService postService)
        {
            _logger = logger;
            PostService = postService;
        }

        public void OnGet()
        {
            Posts = PostService.GetPosts();

        }
    }
}