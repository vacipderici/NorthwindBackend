using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
  public static class Messages
    {
        public static string ProductAdded = "Ürün başaralıyla eklendi.";

        public static string ProductDeleted = "Ürün başaralıyla silindi.";

        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Şifre hatalı";

        public static string SuccessfulLogin = "Sisteme giriş başarılı";

        public static string UserAlreadyExist = "Bu kullanıcı zaten mecvut";

        public static string UserRegistered = "Kullanıcı kayıt işlemi başarılı";

        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
    }
}
