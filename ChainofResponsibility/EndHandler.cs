using System;
using System.Collections.Generic;
using System.Text;

namespace ChainofResponsibility
{
    internal class EndHandler : IHandler<string>
    {
        public string Handle(string data)
        {
            return data;
        }
    }
}
