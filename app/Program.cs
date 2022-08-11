using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            double str;
            Console.WriteLine("Введите число используя знак - ',' ");
            str = Convert.ToDouble(Console.ReadLine());
            
            double a = Convert.ToDouble(str);
            Console.WriteLine("Вы ввели число " + str);

        }
    }
}
