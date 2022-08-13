using System.Collections.Generic;

namespace Pixieset.Models
{
    public class SuiteTitle
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public List<SuiteImage> Images { get; set; }

    }
}
