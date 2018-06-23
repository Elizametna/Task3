using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double x, y; 
                bool ok; 

                do 
                {
                    Console.Write("Введите координату x: "); 
                    string buf = Console.ReadLine();
                    ok = Double.TryParse(buf, out x); 
                    if (!ok) Console.WriteLine("Неправильный ввод, попробуй ещё раз");
                } while (!ok); 

                do 
                {
                    Console.Write("Введите координату y: "); 
                    string buf = Console.ReadLine(); 
                    ok = Double.TryParse(buf, out y);
                    if (!ok) Console.WriteLine("Неправильный ввод, попробуй ещё раз"); 
                } while (!ok); 

                bool belong = (y >= 0 && y <= 1) && (x >= 0 && x <= 1 && x <= y ) || (y > 1);
                Console.WriteLine(belong);
                Console.ReadLine();
            }
        }
    }
}

