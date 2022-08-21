using System;

namespace FirstProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вас зовут {Name} и Вам {Age} года");
            Console.Write("Введите Вашу дату рождения: ");
            var Birthdate = Console.ReadLine();
            Console.WriteLine($"Вы родились {Birthdate}");
            Console.ReadKey();
        } 
    }
}
