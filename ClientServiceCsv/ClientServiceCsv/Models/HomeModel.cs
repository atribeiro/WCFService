using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data.Entity;

namespace ClientServiceCsv.Models
{
    public class HomeModelList : List<HomeModel>
    {
        public int FromPortugal { 
            get {
                return this.Count(x => x.Country == "Portugal");
            }
        }
    }

    public class HomeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
