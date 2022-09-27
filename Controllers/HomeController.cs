using Microsoft.AspNetCore.Mvc;
using PageFilterSortApp.Common;
using PageFilterSortApp.Data.Context;
using PageFilterSortApp.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerContext _customerContext;
        private readonly ICommonMethods _methods;
        public HomeController(CustomerContext customerContext, ICommonMethods methods)
        {
            _customerContext = customerContext;
            _methods = methods;
        }

        public async Task<IActionResult> Index(int currentPage=1, int pageSize=5, bool isAscending = false, int propertyType = 1)
        {
            var paginatedCustomerShowModel =await _methods.GetAllByPagingAsync(currentPage, pageSize, isAscending, propertyType);
          
            return View(paginatedCustomerShowModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(int currentPage = 1, int pageSize = 5, int propertyType = 1, bool isAscending = false)
        {
            var paginatedCustomerShowModel = await _methods.GetAllByPagingAsync(currentPage, pageSize, isAscending, propertyType);
            return View(paginatedCustomerShowModel);
        }
    }
}
