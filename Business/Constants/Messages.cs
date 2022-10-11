namespace Business.Constants
{
    //temel mesajlarımızı buraya yazıcaz.
    public static class Messages //newlemeye gerek kalmamak için static kullanırız bu sayede direk Messages. ile propertylerine ulaşabiliriz.
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        internal static string MaintenanceTime = "Sistem Bakımda.";
        internal static string ProductsListed = "Ürünler Listelendi.";
    }
}
