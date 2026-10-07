using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismHomework7
{
    public class CargoDelivery : DeliveryBase, IDelivery
    {
        public decimal CalculatePrise(int weight)//сервису не важно что внутри грузовая доствка  он знает только что это какая то доставка а у любой доставки есть метод
        {
            return weight * 50m;
        }
    }
}
