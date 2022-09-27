using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageFilterSortApp.Models
{
    public abstract class ModelBase
    {
        //Pagination
        public virtual int CurrentPage { get; set; } = 1; 
        public virtual int PageSize { get; set; } = 5; 
        public virtual int TotalCount { get; set; } 
        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize)); 
        public virtual bool ShowPrevious => CurrentPage > 1;  
        public virtual bool ShowNext => CurrentPage < TotalPages;
        public virtual bool IsAscending { get; set; } = false;
        public virtual int PropertyType { get; set; }
    }
}
