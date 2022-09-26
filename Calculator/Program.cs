using System.Numerics;
using System.Xml.Linq;
Console.WriteLine("Выберите операцию, которую хотите выполнить:" +
    "\n 1 - Сложить два числа" +
    "\n 2 - Вычесть первое из второго" +
    "\n 3 - Перемножить два числа" +
    "\n 4 - Разделить первое на второе" +
    "\n 5 - Возвести в степень N первое число" +
    "\n 6 - Найти квадратный корень из числа" +
    "\n 7 - Найти 1 процент от числа" +
    "\n 8 - Найти факториал из числа" +
    "\n 9 - Выйти из программы");
int Action = Convert.ToInt32(Console.ReadLine());
while (Action < 9)
    if (Action < 5)
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        switch (Action)
        {
            case 1:
                Console.WriteLine($"Результат сложения {num1} + {num2} = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"Результат вычитания {num2} - {num1} = {num2 - num1}");
                break;
            case 3:
                Console.WriteLine($"Результат умножения {num1} * {num2} = {num1 * num2}");
                break;
            case 4:
                Console.WriteLine($"Результат деления {num1} / {num2} = {num1 / num2}");
                break;
        }
        Console.WriteLine("Выберите операцию, которую хотите выполнить:");
        Action = Convert.ToInt32(Console.ReadLine());
        
    }
    else if (Action == 5)
    {
        Console.WriteLine("Введите число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите степень, в которую хотите возвести число:");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат возведения числа {num1} в степень {N} = {Math.Pow(num1, N)}");
        Console.WriteLine("Выберите операцию, которую хотите выполнить:");
        Action = Convert.ToInt32(Console.ReadLine());
    }
    else if (Action > 5 && Action < 9)
    {
        Console.WriteLine("Введите число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        switch (Action)
        {
            case 6:
                Console.WriteLine($"Квадратный корень из числа {num1} = {Math.Sqrt(num1)}");
                break;
            case 7:
                Console.WriteLine($"1 процент от числа {num1} = {num1 / 100}");
                break;
            case 8:
                int fact = 1;
                for (int a = 1; a <= num1; a++)
                {
                    fact *= a;
                }
                Console.WriteLine($"Факториал числа {num1} = {fact}");
                break;
        }
        Console.WriteLine("Выберите операцию, которую хотите выполнить:");
        Action = Convert.ToInt32(Console.ReadLine());
    }
if (Action == 9)
{
    Console.WriteLine("Вы вышли из программы");
}



