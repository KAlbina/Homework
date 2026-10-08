using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChainofResponsibility
{
    internal class CardHandler : IHandler<string>
    {
        private IHandler<string> _next;
        public CardHandler(IHandler<string> next)
        {
            _next = next;
        }
        public string Handle(string data)
        {
            data = Regex.Replace(data, @"\b(\d{12})(\d{4})\b", "************$2");
            return _next.Handle(data);
        }
    }
}
