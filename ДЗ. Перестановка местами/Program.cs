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
            string correctSurname;
            string correctName;
            correctName =surname;
            correctSurname = name;
            Console.WriteLine($"Нет, моё имя {correctName}, а фамилия {correctSurname}");

            string largeCup = "кофе";
            string smaillСup = "чай";
            Console.WriteLine($"Вам нужно в большой чашке {largeCup}, а в маленькой {smaillСup} ?");
            string rideDringInLargeCup=smaillСup;
            string rideDringInSmallCup=largeCup;
            Console.WriteLine($"Принесите в большой чашке {rideDringInLargeCup}, а в маленькой {rideDringInSmallCup}");

        }
    }
}
