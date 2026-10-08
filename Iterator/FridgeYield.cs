using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class FridgeYield : IEnumerable<Product>
    {

        private readonly List<Product> _products;

        public FridgeYield(List<Product> products)
        {
            _products = products;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            foreach (Product product in _products)
            {
                if (product.IsFresh)
                    yield return product;    
                                             
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
