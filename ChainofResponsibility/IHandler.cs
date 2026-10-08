using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    public interface IHandler<T>
    {
        T Handle(T data);
    }
}
