using nmct.own.pagination.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmct.own.pagination.test
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Product> products = Product.GetProducts();
            PagedList<Product> pagedList = new PagedList<Product>(products);

            PagedList<Product> firstPage = pagedList.GetPage(1);
            PagedList<Product> secondPage = pagedList.GetPage(2);
            PagedList<Product> thirdPage = pagedList.GetPage(3);
        }
    }
}
