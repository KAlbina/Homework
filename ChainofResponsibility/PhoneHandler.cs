using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ChainofResponsibility
{
    public class PhoneHandler : IHandler<string>
    {
        private IHandler<string> _next;
        
        public PhoneHandler(IHandler<string> next)
        {
            _next = next;
        }
         public string Handle(string data)
        {
            data = Regex.Replace(data,  @"\b(\d{8})(\d{3})\b", "********$2");
            return _next.Handle(data);
        }
    }
}
