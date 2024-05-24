using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public List<string> LeadActors { get; set; }
        public string Summary { get; set; }
        public double Rating { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
    }


}
