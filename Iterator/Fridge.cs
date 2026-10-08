using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Fridge : IEnumerable<Product>
    {
        private readonly List<Product> _products;     

        public Fridge(List<Product> products)
        {
            _products = products;
        }

        public IEnumerator<Product> GetEnumerator()   
        {
            return new FreshProductEnumerator(_products);
        }

        IEnumerator IEnumerable.GetEnumerator()       
        {
            return GetEnumerator();
        }
    }
}
