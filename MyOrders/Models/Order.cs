using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyOrders.Models
{
    public class Order
    {
        [Display(Name = "Номер заказа")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Display(Name = "Город отправителя")]
        public string CitySender { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Display(Name = "Адрес отправителя")]
        public string AddressSender { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Display(Name = "Город получателя")]
        public string CityRecipient { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Display(Name = "Адрес получателя")]
        public string AddressRecipient { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Range(0,200, ErrorMessage = "Недопустимое значение!")]
        [Display(Name = "Вес груза (кг)")]
        public int CargoWeight { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено!")]
        [Display(Name = "Дата забора груза")]
        [DataType(DataType.Date)]
        public DateTime DateReceipt { get; set; }
    }
}
