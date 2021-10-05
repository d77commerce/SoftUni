using System;
using System.Collections.Generic;
using System.Text;

namespace classAndConstructors
{
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Order> Orders;
        public Person()
        {
            Orders = new List<Order>();
        }
        public Person(int id)
            : this()
        {
            Id = id;
        }
        public Person(int id, string name)
            :this(id)
        {
            Id = id;
            Name = name;

        }
        
    }
}
