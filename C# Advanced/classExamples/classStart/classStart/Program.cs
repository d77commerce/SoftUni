using System;

namespace classStart
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Age = 23;
            personOne.FirstName = "Emo";
            personOne.LastName = "Kirov";
            Person[] people = new Person[100];
            people[45] = new Person();
            people[4] = new Person();
            people[4].FirstName = "Koki";
            people[4].Age = 34;
            people[45].Age = 74;
            Console.WriteLine(personOne.GetFullName());
            Console.WriteLine(people[4].GetFullName());
            Console.WriteLine(people[4].Age+ " "+ people[45].Age);

        }
    }

}
