using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//ProductTest();
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetAll())
    {
        Console.WriteLine(product.ProductName);
    }
}
//foreach (var product in productManager.GetAllByCategoryId(2))
//{
//    Console.WriteLine(product.ProductName);
//}
//foreach (var product in productManager.GetByUnitPrice(50, 100))
//{
//    Console.WriteLine(product.ProductName);
//}
