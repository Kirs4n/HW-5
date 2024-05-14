using System;

namespace ДЗ.Перестановка_местами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "London";
            string surname = "Jack";
            Console.WriteLine($"Ваше имя {name}, а фамилия {surname} ?");
            (name,surname)=(surname,name);
            Console.WriteLine($"Нет, моё имя {name}, а фамилия {surname}");

            string largeCup = "кофе";
            string smaillСup = "чай";
            Console.WriteLine($"Вам нужно в большой чашке {largeCup}, а в маленькой {smaillСup} ?");
            (largeCup,smaillСup) = (smaillСup, largeCup);
            Console.WriteLine($"Принесите в большой чашке {largeCup} , а в маленькой  {smaillСup}");

        }
    }
}
