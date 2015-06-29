# nmct.own.pagination
Paged Lists inspirated by many developers online

Usage:
Add these files to your project: [PagedList] (https://github.com/stijnmoreels/nmct.own.pagination/blob/master/nmct.own.pagination.core/PagedList.cs) & [PagedListExtension]
(https://github.com/stijnmoreels/nmct.own.pagination/blob/master/nmct.own.pagination.core/PagedListExtension.cs)

## Example list
```
 IEnumerable<Product> products = Product.GetProducts();
```

## 1. First approach
```
PagedList<Product> pagedList = new PagedList<Product>(products);

PagedList<Product> firstPage = pagedList.GetPage(1);
PagedList<Product> secondPage = pagedList.GetPage(2);
```

## 2. Second approach (Extension Methods)
Add namespace "PagedListExtensions" to your file

```
using PagedListExtensions;
```

```
PagedList<Product> fourthPage = products.ToPagedList<Product>(4);
PagedList<Product> fifthPage = products.ToPagedList<Product>(5);
```

Thank you
