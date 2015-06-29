using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmct.own.pagination.core
{
    public class PagedList<T> where T : class
    {
        public int PageSize { get; set; }
        public int TotalItemCount { get; set; }
        public int CurrentPage { get; set; }

        private IEnumerable<T> _items;
        public IEnumerable<T> Items
        {
            get 
            {
                // ----------------------------------------------------------------------------------------------------
                // Multiply the CurrentPage and PageSize (amount to Skip) and take the amount for one page (PageSize)
                //-----------------------------------------------------------------------------------------------------
                return _items.Skip((this.CurrentPage - 1) * this.PageSize).Take(this.PageSize); 
            }
            set { _items = value; }
        }
        

        // ---------------------------------------------------------------------------
        // One-based numbering (CurrentPage)
        // ---------------------------------------------------------------------------
        public PagedList(IEnumerable<T> items, int currentPage = 1, int pageSize = 20)
        {
            this.Items = items;
            this.PageSize = pageSize;
            this.CurrentPage = currentPage;
            this.TotalItemCount = items.Count<T>();
        }

        public PagedList<T> GetPage(int page)
        {
            this.CurrentPage = page;
            return this;
        }
    }
}
