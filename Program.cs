//Користувач вводить з клавіатури чотири цифри. Необхідно створити число, яке містить ці цифри.
//Наприклад, якщо з клавіатури введено 1, 5, 7, 8 тоді потрібно сформувати число 1578.

using System;

class Program
{
    static void Main()
    {
        int n1, n2, n3, n4;

        Console.Write("Введіть перше число: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть третє число: ");
        n3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть четверте число: ");
        n4 = Convert.ToInt32(Console.ReadLine());

        int Number = n1 * 1000 + n2 * 100 + n3 * 10 + n4;

        Console.Write($"Число із введених чотирьох цифр: {Number}");
        Console.ReadLine();
    }
}
