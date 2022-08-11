using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            double str;
            Console.WriteLine("Введите расстояние в см ");
            str = Convert.ToDouble(Console.ReadLine());
            
            double a = Convert.ToDouble(str);
            Console.WriteLine("Расстояние в км " + str/1000);

        }
    }
}
