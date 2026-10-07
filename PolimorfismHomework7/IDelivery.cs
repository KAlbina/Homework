using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismHomework7
{
    public interface IDelivery
    {
        decimal CalculatePrise(int weight);// у любой доставки должен быть метод расчета цены
    }
}
