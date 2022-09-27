using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Models
{
    public class CustomerShowModel : ModelBase
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int TotalOrderCount { get; set; }
        public string MarriageStatus { get; set; }
    }
}
