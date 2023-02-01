using FirstASPwebsite.Models;
using FirstASPwebsite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstASPwebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        public PostsController(JsonFilePostService postsService)
        {
            this.PostsService = postsService;
        }

        public JsonFilePostService PostsService { get; }

        [HttpGet]
        public IEnumerable<Post> GetPosts()
        {
            return PostsService.GetPosts();
        }

        [HttpGet]
        [Route("Rate")]
        public ActionResult Get([FromQuery]long id, [FromQuery]int Rating)
        {
            PostsService.AddRating(id, Rating);
            return Ok();
        }
    }
}
