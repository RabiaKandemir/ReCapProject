using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarDeleted = "Araba silindi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string  ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk silindi";
        public static string ColorDeleted = "Renk silindi";

        public static string UserAdded = "Kişi eklendi";
        public static string UserUpdated = "Kişi güncellendi";
        public static string UserDeleted = "Kişi silindi";

        public static string CustomerDeleted = "Müşteriler silindi";
        public static string CustomerAdded = "Müşteriler eklendi";
        public static string CustomerUpdated = "Müşteriler güncellendi";

        public static string RentalUpdated = "Araba kiralama bilgileri güncellendi";
        public static string RentalAdded = "Araba kiralama bilgileri eklendi";
        public static string RentalDeleted = "Araba kiralama bilgileri silindi";

        public static string NotCarAdded = "Araba eklenemedi";
        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarListed = "Arabalar listelendi";
        public static string BrandListed = "Markalar listelendi";
        public static string ColorListed = "Renkler listelendi";
        public static string UserListed = "Kişiler listelendi";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string RentalListed = "Kiralama bilgileri listelendi";
        public static string RentalDetailsListed = "Kiralama bilgileri detayları listelendi";
        public static string RentalCarError = "Kiralama bilgileri eklenemedi. Bu araba şu an bulunmamaktadır";
    }
}
