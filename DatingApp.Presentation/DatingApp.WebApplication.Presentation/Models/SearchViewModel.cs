using DatingApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Models
{
    public class SearchViewModel
    {       
            public string FirstName { get; set; }
            public int AgeFrom { get; set; }
            public int AgeTo { get; set; }
            public int CityId { get; set; }
            public string City { get; set; }
            public Sex Sex { get; set; }
            public Orientations Orientation { get; set; }
        
    }
}
