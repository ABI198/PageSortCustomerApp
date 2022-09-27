using PageFilterSortApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Mappings
{
    public class CustomerMapper : ICustomerMapper
    {
        public List<CustomerShowModel> MapToCustomerShowModel(List<Customer> customerList)
        {
            List<CustomerShowModel> customerShowModelList = new List<CustomerShowModel>();
            foreach (var customer in customerList)
            {
                customerShowModelList.Add(new CustomerShowModel()
                {
                    Firstname = customer.Firstname,
                    Lastname = customer.Lastname,
                    Age = customer.Age,
                    Gender = customer.Gender,
                    MarriageStatus = customer.MarriageStatus,
                    TotalOrderCount = customer.TotalOrderCount
                });
            }
            return customerShowModelList;
        }
    }
}
