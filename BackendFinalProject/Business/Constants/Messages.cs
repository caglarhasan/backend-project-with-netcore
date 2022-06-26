using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Products
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz. Ürün ismi en az 2 karakter olmalıdır.";
        public static string MaintenanceTime = "Ürün/Ürünler listenelemedi. Sistem bakımda.";
        public static string ProductsListed = "Ürün/Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün yer alabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün vardır.";

        //Categories
        public static string CategoryListed = "Kategori/Kategoriler listelendi";
        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryNameInvalid = "Kategori ismi geçersiz. Kategori ismi en az 2 karakter olmalıdır.";
        public static string CategoryLimitExceded = "Toplam kategori sayısı 15'i geçti. Yeni ürün eklenemiyor.";
        public static string CategoryNameAlreadyExists = "Bu isimde zaten başka bir kategori var.";

        //Customers
        public static string CustomerListed = "Müşteri/Müşteriler listelendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerIdInvalid = "Müşteri ID'si geçersiz. Müşteri ID'si en az 5 karakter olmalıdır.";

        //Orders
        public static string OrderAdded = "Sipariş oluşturuldu.";
        public static string OrderListed = "Sipariş/Siparişler listelendi.";
        public static string OrderByCustomerListed = "Müşteriye ait sipariş/siparişler listelendi.";

        //Employee 
        public static string EmployeeFirstNameInvalid = "Personel ismi geçersiz. Personel ismi en az 2 karakter olmalıdır.";
        public static string EmployeeLastNameInvalid = "Personel soyadı geçersiz. Personel soyadı en az 2 karakter olmalıdır.";
        public static string EmployeeListed = "Personel/Personeller listelendi.";
        public static string EmployeeAdded = "Personel eklendi.";
        
    }
}
