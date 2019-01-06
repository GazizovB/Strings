using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ нажимая через Enter: ");
            char simbol;
            int count = 0;
            int count_space = 0;

            while (true)
            {
                simbol = char.Parse(Console.ReadLine());
                if (simbol == '.')
                {
                    break;
                }
                else if (simbol == ' ')
                {
                    count_space++;
                }
                count++;
            }

            Console.WriteLine("Количество отображенных символов: {0}", count - count_space);

            Console.WriteLine("Количество пробелов: {0}", count_space);
            Console.WriteLine("Количество всех символов: {0}", count);



            Console.ReadLine();
        }
    }
}