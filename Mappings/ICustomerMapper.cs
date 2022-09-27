using PageFilterSortApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Mappings
{
    public interface ICustomerMapper
    {
        List<CustomerShowModel> MapToCustomerShowModel(List<Customer> customerList);
    }
}
