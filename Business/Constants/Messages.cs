namespace Business.Constants
{
    //temel mesajlarımızı buraya yazıcaz.
    public static class Messages //newlemeye gerek kalmamak için static kullanırız bu sayede direk Messages. ile propertylerine ulaşabiliriz.
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Ürüne ait kategori sayısı çok fazla.";
        public static string ProductnameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}
