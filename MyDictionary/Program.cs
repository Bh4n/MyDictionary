using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, String> cities = new MyDictionary<int, string>();
            cities.Add(1, "Adana");
            cities.Add(2, "Adıyaman");

            Console.WriteLine("Length: " + cities.Length);

            cities.Add(3, "Afyon");
            cities.Add(4, "Ağrı");
            cities.Add(5, "Amasya");
            cities.Add(6, "Ankara");

            Console.WriteLine("Length: " + cities.Length);

            cities.List();
        }
    }
}
