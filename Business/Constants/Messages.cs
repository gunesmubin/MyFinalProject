using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenceTime = "Sistem Bakım Zamanı";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Sayı Aşıldı";
        public static string ProductNameAlreadyExists = "Ürün Adı Zaten Var";

        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı";

        public static string AuthorizationDenied = "AuthorizationDenied";
        public static string UserRegistered= "UserRegistered";
        public static string UserNotFound= "UserNotFound";
        public static string PasswordError= "PasswordError";
        public static string SuccessfulLogin= "SuccessfulLogin";
        public static string UserAlreadyExists= "UserAlreadyExists";
        public static string AccessTokenCreated= "AccessTokenCreated";
    }
}
