using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
      

        public static T[] Create<T>(int len, T item)
        {
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = item;
            }
            return result;
        }


    }
}

