using Pixieset.Models;
using System.Collections.Generic;
namespace Pixieset.ViewModels
{
    public class ExampleVM
    {
        public ExampleFirst ExampleFirst { get; set; }
        public List<ExampleMenu> ExampleMenus { get; set; }
        public List<ExamplesRow> ExampleRows { get; set; }
     
        public List<ActionsIcons> ActionsIcons { get; set; }
    
       public List<ExampleActions> ExampleActions { get; set; }
        public List<Item>Items { get; set; }
        public ExpTitles ExpTitles { get; set; }
        public Get Get { get; set; }
        public List<Act> Acts { get; set; }

    }
}
