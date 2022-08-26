using Microsoft.AspNetCore.Http;

namespace Pixieset.ViewModels
{
    public class MediaEdit
    {
        public int Id { get; set; } 
        public string ImagePath { get; set; }
        public IFormFile File { get; set; }
        public int CategoryId { get; set; }

    }
}
