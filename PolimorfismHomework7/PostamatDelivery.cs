using System;
using System.Collections.Generic;
using System.Text;
//И каждый из них обязан иметь:

//CalculatePrice(int weight)

//но считать цену может по своей формуле.

//И вот именно поэтому интерфейс IDelivery здесь очень удобно использовать для полиморфизма.

namespace PolimorfismHomework7
{
    internal class PostamatDelivery : DeliveryBase, IDelivery
    {
        public decimal CalculatePrise(int weight)
        {
            return weight * 30m;
        }
    }
}

