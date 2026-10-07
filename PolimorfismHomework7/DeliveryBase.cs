using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfismHomework7
{
    //базовый класс доставки , где можем получить информацию о доставке
    public class DeliveryBase
    {
        public virtual string GetDeliveryInfo()
        {
            return "обычная доствка";
        }
    }
}
