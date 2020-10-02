using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazvetAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double y;
                if (x >= 0) y = x;
                else y = -x;
                Console.WriteLine("|"+x+"|="+y);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Начальный
            try
            {
                Console.Write("Введите x:");
                uint x = uint.Parse(Console.ReadLine());
                if (x % 2 == 0 || x % 10 == 7) Console.WriteLine("Является четным или заканчивается цифрой 7");
                else Console.WriteLine("Не Является четным или заканчивается цифрой 7");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Средний
            try
            {
                Console.Write("Введите a:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите b:");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите c:");
                int c = int.Parse(Console.ReadLine());
                int max = a;
                if (b > max) max = b;
                if (c > max) max = c;
                Console.WriteLine("Наибольшее "+max);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Средний
            try
            {
                Console.Write("Введите x1:");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите y1:");//
                double y = double.Parse(Console.ReadLine());
                if(y>=x&&y>=-x&&y<=1&&y>=0) Console.WriteLine("Попадает");
                else Console.WriteLine("Не попадет");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
