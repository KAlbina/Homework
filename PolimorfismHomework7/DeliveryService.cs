using System;
using System.Collections.Generic;
using System.Text;
//сервис доставки - пол IDelivery - прос CalculatePrice- конкрет доставка считает цену
namespace PolimorfismHomework7
{
    public class DeliveryService//наш сервис доставки
    {
        public decimal CalculatePrise(IDelivery delivery, int weight)//метод  который принимает какую-то доставку и вес и возвращает цену
        {
            return delivery.CalculatePrise(weight);//Попросить доставку самой рассчитать цену для этого веса и вернуть полученный результат
        }
    }
}
