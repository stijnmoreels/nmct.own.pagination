using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmct.own.pagination.test
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Shipper { get; set; }

        public Product(int id, string name, double price, string shipper)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Shipper = shipper;
        }

        public static IEnumerable<Product> GetProducts()
        {
            IList<Product> list = new List<Product>();
            for (int j = 0; j < 10; j++)
            {
                int id = 1;
                for (int i = 1; i < 1000; i++)
                {
                    list.Add(new Product(id, "Dell PC", 1200, "Dell"));
                    list.Add(new Product(id + 1, "HP Pc", 1100, "HP"));
                    list.Add(new Product(id + 2, "Levovo", 1000, "Lenovo"));
                    id += 3;
                } 
            }
            return list;
        }
    }
}
