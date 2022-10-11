using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var Result = productManager.GetProductDetails();

    if (Result.Success == true)
    {
        foreach (var product in Result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(Result.Message);
    }

    //foreach (var product in productManager.GetProductDetails().Data)
    //{
    //    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    //}
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
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
