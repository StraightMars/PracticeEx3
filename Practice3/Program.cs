using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //+test
            bool ok;
            double x, y;
            bool result;
            Console.WriteLine("Введите абсциссу точки: ");
            do
            {
                ok = double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("Ошибка ввода. Введите действительное число.");
            } while (!ok);
            Console.WriteLine("Введите ординату точки: ");
            do
            {
                ok = double.TryParse(Console.ReadLine(), out y);
                if (!ok)
                    Console.WriteLine("Ошибка ввода. Введите действительное число.");
            } while (!ok);
            if (Math.Abs(x) <= 1 && Math.Abs(y) <= 1)
                result = true;
            else
                result = false;
            Console.WriteLine(result);
        }
    }
}
