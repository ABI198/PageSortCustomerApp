using Microsoft.EntityFrameworkCore;
using PageFilterSortApp.Data.Context;
using PageFilterSortApp.Mappings;
using PageFilterSortApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Common
{
    public class CommonMethods : ICommonMethods
    {
        private readonly CustomerContext _customerContext;
        private readonly ICustomerMapper _mapper;
        public CommonMethods(CustomerContext customerContext, ICustomerMapper mapper)
        {
            _customerContext = customerContext;
            _mapper = mapper;
        }

        public async Task<PaginatedCustomerShowModel> GetAllByPagingAsync(int currentPage, int pageSize, bool isAscending = false, int propertyType = 1) 
        {
            pageSize = (pageSize > 10) ? 10 : pageSize; //Defensive Programming

            var customerList = await _customerContext.Customers.ToListAsync();
            var sortedCustomerList = GetSortedCustomerList(customerList, currentPage, pageSize, isAscending, propertyType);
            var customerShowModelList = _mapper.MapToCustomerShowModel(sortedCustomerList);
            PaginatedCustomerShowModel paginatedCustomerShowModel = new PaginatedCustomerShowModel();
            FillPaginatedCustomerShowModel(ref paginatedCustomerShowModel, customerShowModelList, currentPage, pageSize, customerList.Count, isAscending, propertyType);
            return paginatedCustomerShowModel;
        }

        public void FillPaginatedCustomerShowModel(ref PaginatedCustomerShowModel paginatedCustomerShowModel, List<CustomerShowModel> customerShowModelList, 
            int currentPage, int pageSize, int totalCount, bool isAscending, int propertyType)
        {
            paginatedCustomerShowModel.CustomerShowModelList = customerShowModelList;
            paginatedCustomerShowModel.CurrentPage = currentPage;
            paginatedCustomerShowModel.PageSize = pageSize;
            paginatedCustomerShowModel.TotalCount = totalCount;
            paginatedCustomerShowModel.IsAscending = isAscending;
            paginatedCustomerShowModel.PropertyType = propertyType;
        }

        public List<Customer> GetSortedCustomerList(List<Customer> customerList, int currentPage, int pageSize, bool isAscending, int propertyType)
        {
            List<Customer> sortedCustomerList = new List<Customer>();
            switch (propertyType)
            {
                case 1:   //Firstname
                    sortedCustomerList = PagingAlgorithm(c => c.Firstname, customerList, currentPage, pageSize, isAscending);
                    break;
                case 2:    //Lastname
                    sortedCustomerList = PagingAlgorithm(c => c.Lastname, customerList, currentPage, pageSize, isAscending);
                    break;
                case 3:    //Age
                    sortedCustomerList = PagingAlgorithm(c => c.Age, customerList, currentPage, pageSize, isAscending);
                    break;
                case 4:    //Gender
                    sortedCustomerList = PagingAlgorithm(c => c.Gender, customerList, currentPage, pageSize, isAscending);
                    break;
                case 5:    //TotalOrderCount
                    sortedCustomerList = PagingAlgorithm(c => c.TotalOrderCount, customerList, currentPage, pageSize, isAscending);
                    break;
                case 6:    //MarriageStatus
                    sortedCustomerList = PagingAlgorithm(c => c.MarriageStatus, customerList, currentPage, pageSize, isAscending);
                    break;
                default:      
                    break;
            }
            return sortedCustomerList;
        }
   
        public List<Customer> PagingAlgorithm(Func<Customer, object> filter, List<Customer> customerList, int currentPage, int pageSize, bool isAscending)
        {
            return isAscending ? customerList.OrderBy(filter).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                               : customerList.OrderByDescending(filter).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
