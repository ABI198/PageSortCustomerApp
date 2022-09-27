using PageFilterSortApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Models
{
    public class PaginatedCustomerShowModel : ModelBase
    {
        public List<CustomerShowModel> CustomerShowModelList { get; set; }
    }
}
