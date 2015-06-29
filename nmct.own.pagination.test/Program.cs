using nmct.own.pagination.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedListExtensions;

namespace nmct.own.pagination.test
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Product> products = Product.GetProducts();
            PagedList<Product> pagedList = new PagedList<Product>(products);
            
            // 1. First approach
            PagedList<Product> firstPage = pagedList.GetPage(1);
            PagedList<Product> secondPage = pagedList.GetPage(2);
            PagedList<Product> thirdPage = pagedList.GetPage(3);

            // 2. Second approach
            PagedList<Product> fourthPage = products.ToPagedList<Product>(4);
            PagedList<Product> fifthPage = products.ToPagedList<Product>(5);
            PagedList<Product> sixthPage = products.ToPagedList<Product>(6);
        }
    }
}
