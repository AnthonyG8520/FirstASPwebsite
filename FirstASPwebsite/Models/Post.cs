using System.Text.Json;

namespace FirstASPwebsite.Models
{
    public class Post
    {
        public long Id { get; set; }

        public String ImageUrl { get; set; }

        public String Description { get; set; }

        public int[] Ratings { get; set; }

        public override string ToString(){
           return JsonSerializer.Serialize<Post>(this);
        }

    }
}
