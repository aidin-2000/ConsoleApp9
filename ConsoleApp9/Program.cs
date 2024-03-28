using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Categories = { "Продукты", "Транспорт", "Учеба", "Жильё", "Развлечения" };
            Console.Write("Введите бюджет: ");
            decimal budget = decimal.Parse(Console.ReadLine());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Категории расходов:");
                for (int i = 0; i < Categories.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Categories[i]}");
                }
                Console.WriteLine($"\n Текущий бюджет: {budget}");
                Console.Write("\n Выберите категорию (или введите '0' для выхода): ");
                int categoryIndex = int.Parse(Console.ReadLine()) - 1;
                if (categoryIndex == -1)
                    break;

                Console.Write("Введите сумму расхода: ");
                decimal expense = decimal.Parse(Console.ReadLine());
                if (expense <= budget)
                {
                    budget -= expense;
                    Console.WriteLine("Расход успешно добавлен!");
                }
                else
                {
                    Console.WriteLine("Ошибка! Расход превышает текущий бюджет!");
                }
            
                Console.ReadKey();
            }
        }
    }
}
