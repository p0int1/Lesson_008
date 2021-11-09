using System;
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте статический класс с методом void Print (string stroka, int color), который выводит на 
//экран  строку  заданным  цветом.  Используя  перечисление, создайте  набор  цветов, доступных 
//пользователю. Ввод строки и выбор цвета предоставьте пользователю. 

namespace Task_2
{
    enum Colors
    {
        Red = 0,
        Green = 1,
        Yellow = 2,
        White = 3
    }
    static class FuncPrint
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    break;
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();

            Console.Write("Укажите цифру цвета [0-красный, 1-зеленый, 2-желтый, 3-белый]: ");
            int color = Convert.ToInt32(Console.ReadLine());

            FuncPrint.Print(stroka, color);

            Console.WriteLine("\nНажмите любую клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
