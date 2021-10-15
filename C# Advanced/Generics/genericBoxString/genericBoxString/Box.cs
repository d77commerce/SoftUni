using System;
using System.Collections.Generic;
using System.Text;

namespace genericBoxString
{
    public class Box<T>
    {
        public Box(T type)
        {
            Type=type;
        }
        public T Type { get; set; }
        public override string ToString()
        {
           return $"{typeof(T)}: {Type}";
        }
    }

}

