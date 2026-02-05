using System;

namespace tran1
{
    class Program
    {
        public static void Main()
        {
           Console.Write("Введите цену товара:");
           double price = double.Parse(Console.ReadLine());

           Console.Write("Введите скидку в процентах:");
           double sale = double.Parse(Console.ReadLine());

           double itog_price = price * (1 - sale / 100);
           Console.Write($"Итоговая цена:{itog_price:F2}");

           Console.ReadKey();
        }
    }
}
