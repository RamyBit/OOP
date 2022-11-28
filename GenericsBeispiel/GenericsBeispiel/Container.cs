using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsBeispiel
{
    class Container<T>
    {
        public List<T> liste { get; } = new List<T>();
        public T variable { get; set; }

        public void Add(T element)
        {
            liste.Add(element);
        }
    }
}
