using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Реализуйте  программу, которая  будет  принимать  от  пользователя  дату  его  рождения  и  выводить 
//количество дней до его следующего дня рождения. 

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime birthday;
            TimeSpan howWait;

            Console.Write("Введите дату вашего рождения[dd.mm]: ");
            birthday = Convert.ToDateTime(Console.ReadLine());

            DateTime nowYear = new DateTime(now.Year, birthday.Month, birthday.Day);
            Console.WriteLine($"                 Сегодня такая дата: {now:d}");

            if (nowYear < now)
            {
                nowYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day); 
                howWait = nowYear - now;
            }
            else
            {
                howWait = nowYear - now;
            }

            Console.WriteLine($"            Ближайший день рожденья: {nowYear:d}");
            Console.WriteLine($"До ближайшего дня рождения осталось: {howWait.Days} дней");

            Console.WriteLine("\nНажмите любую клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
