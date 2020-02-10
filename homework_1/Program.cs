using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Номер 1
            bool b = true;
            char c = 'c';
            int a = 2407;
            float f = 3.14f;
            double d = 24.07;
            string s = "string";
            byte by = 24;
            long l = 2509;
            short sh = 1707;
            uint u = 161179;

            Console.WriteLine($"Переменная типа int a равна: {a}");
            Console.WriteLine($"Переменная типа bool b равна: {b}");
            Console.WriteLine($"Переменная типа char c равна: {c}");
            Console.WriteLine($"Переменная типа double d равна: {d}");
            Console.WriteLine($"Переменная типа float f равна: {f}");
            Console.WriteLine($"Переменная типа string s равна: {s}");
            Console.WriteLine($"Переменная типа byte by равна: {by}");
            Console.WriteLine($"Переменная типа lonf l равна: {l}");
            Console.WriteLine($"Переменная типа short sh равна: {sh}");
            Console.WriteLine($"Переменная типа uint u равна: {u}");

            Console.WriteLine();

            Console.WriteLine("Размер типа int = " + sizeof(int));
            Console.WriteLine("Размер типа bool = " + sizeof(bool));
            Console.WriteLine("Размер типа char = " + sizeof(char));
            Console.WriteLine("Размер типа double = " + sizeof(double));
            Console.WriteLine("Размер типа float = " + sizeof(float));
            Console.WriteLine("Размер типа byte = " + sizeof(byte));
            Console.WriteLine("Размер типа long = " + sizeof(long));
            Console.WriteLine("Размер типа short = " + sizeof(short));
            Console.WriteLine("Размер типа uint = " + sizeof(uint));

            //Номер 2
            short shrt1 = by;
            int i1 = by;
            long lng1 = by;
            short shrt2 = (short)a;
            long lng2 = a;
            long lng3 = u;
            float fl = (float)d;
            double dl = f;
            int i2 = c;
            char ch1 = (char)a;
            char ch2 = (char)by;

            Console.WriteLine();

            //Номер 3
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество:");
            string spatronymictr = Console.ReadLine();
            Console.WriteLine($"{name} {surname} {spatronymictr}");

            Console.WriteLine();

            //Номер 4
            Console.WriteLine("Введите первое число:");
            string number1 = Console.ReadLine();
            int x = Convert.ToInt32(number1);
            Console.WriteLine("Введите второе число:");
            string number2 = Console.ReadLine();
            int y = Convert.ToInt32(number2);
            Console.WriteLine("Введите нужное действие (+, -, *, /): ");
            string action = Console.ReadLine();

            if (action == "+")
                Console.WriteLine($"{x} + {y} = " + (x + y));
            else if (action == "-")
                Console.WriteLine($"{x} - {y} = " + (x - y));
            else if (action == "*")
                Console.WriteLine($"{x} * {y} = " + (x * y));
            else
                Console.WriteLine($"{x} / {y} = "+ (float)x/(float)y);
            
            Console.Read();
        }
    }
}
