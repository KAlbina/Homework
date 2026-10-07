using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismHomework7
{
    public class DroneDelivery : DeliveryBase, IDelivery
    {
        public decimal CalculatePrise(int weight)
        {
            return weight * 80m;
        }
        public override string GetDeliveryInfo()
        {
            return "Доставка дроном не доставляет при сильном ветре";
        }
    }
}
