using PageFilterSortApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Common
{
    public interface ICommonMethods
    {
        Task<PaginatedCustomerShowModel> GetAllByPagingAsync(int currentPage = 1, int pageSize = 5, bool isAscending = false, int propertyType = 1); 
    }
}
