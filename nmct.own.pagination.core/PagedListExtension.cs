using nmct.own.pagination.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedListExtensions
{
    public static class PagedListExtension
    {
        public static PagedList<T> ToPagedList<T>(this IEnumerable<T> items, int currentPage = 1, int pageSize = 20) where T : class
        {
            return new PagedList<T>(items, currentPage, pageSize);
        }
    }
}
