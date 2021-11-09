using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант. 
//Присвойте  каждой  константе  значение, задающее  количество  часов, которые  должен  отработать 
//сотрудник за месяц.  
//Создайте класс Accountant с методом bool AskForBonus(Post worker, int hours), отражающее
//давать или нет сотруднику премию. Если сотрудник отработал больше положенных часов в месяц, то ему 
//положена премия. 

namespace Task_3
{
    enum Post
    {
        // должность и минимальное количество часов в месяц
        Analyst = 130,
        Developer = 120,
        Accountant = 110
    }
    class Accauntant
    {
        // положена ли премия?
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество отработаных часов: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accauntant instance = new Accauntant();

            if (instance.AskForBonus(Post.Developer, hours))
                Console.WriteLine("Была переработка по времени. Выдать премию!");
            else
                Console.WriteLine("Количество часов не достаточное. Не выдавать премию.");

            Console.WriteLine("\nНажмите любую клавишу для выхода..");
            Console.ReadKey();

        }
    }
}
