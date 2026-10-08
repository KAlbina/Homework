using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class FreshProductEnumerator : IEnumerator<Product>
    {
        private readonly List<Product> _products;
        private int _position = -1;                   

        public FreshProductEnumerator(List<Product> products)
        {
            _products = products;
        }

        public Product Current => _products[_position];   
        object IEnumerator.Current => Current;            

        public bool MoveNext()                        
        {
            _position++;                              

            while (_position < _products.Count)       
            {
                if (_products[_position].IsFresh)     
                    return true;

                _position++;                          
            }

            return false;                             
        }

        public void Reset() { _position = -1; }       
        public void Dispose() { }
    }
}
