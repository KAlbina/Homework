using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismHomework7
{
    public class CourierDelivery : DeliveryBase, IDelivery
    {
        public decimal CalculatePrise(int weight)
        {
            return weight * 100m;
        }
    }
}
