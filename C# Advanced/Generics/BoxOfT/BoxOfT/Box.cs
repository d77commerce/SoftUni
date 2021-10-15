using System;
using System.Collections.Generic;
using System.Text;

namespace boxOfT
{
    public class Box<T> 
    {
       private Stack<T> box = new Stack<T>();
        public Box()
        {
            box = new Stack<T>();
        }
        public void Add(T element)
        {
            box.Push(element);
        }
        public  T Remove()=>box.Pop();
        public int Count => box.Count;

    }
}
