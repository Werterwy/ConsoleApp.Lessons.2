using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson1
{
    internal class Program
    {

        /// <summary>
        /// 1.	Написать программу, которая считывает символы с клавиатуры,
        /// пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.                 
        /// </summary>
        static void Exmpl09()
        {
            Console.Write("Введите символ: ");
            int num = 0;
            while (true)
            {
                char sim = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите символ: ");
                if (sim == '.')
                {
                    break;
                }
                num++;
            }
            Console.WriteLine("Количество символов " + num);

        }

        /// <summary>
        /// 2.	Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым
        /// (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым). 
        /// </summary>
        static void Exmpl10()
        {
            Console.Write("Введите номер трамвайного билета: ");
            string num = Convert.ToString(Console.ReadLine());
            if (num.Length == 6)
            {
                int[] m = new int[6];
                for (int t = 0; t < num.Length; t++)
                {
                    m[t] = (int)num[t];
                }
                int sum1 = m[0] + m[1] + m[2];
                int sum2 = m[3] + m[4] + m[5];
                if (sum1 == sum2)
                {
                    Console.WriteLine("счастливым");
                }
                else
                {
                    Console.WriteLine("не счастливым");
                }
            }
        }
        /// <summary>
        /// 4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно;
        /// каждое число должно выводиться на новой строке; при этом каждое 
        /// число должно выводиться количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод: 
        /// </summary>
        static void Exmpl11()
        {
            Console.Write("Введите А=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите В=");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            for (int t = 0; t < b - a + 1; t++)
            {
                for (int t2 = 0; t2 < temp; t2++)
                {
                    Console.Write(temp + " ");
                }
                Console.WriteLine();
                temp++;
            }

        }
        /// <summary>
        /// 6.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
        /// </summary>
        static void Exmpl12()
        {
            int a, b, c;
            a = 2; b = 5; c = 12;
            Console.WriteLine(a + " " + b + " " + c);
        }

        /// <summary>
        /// 7.	Вывести на экран числа 5, 10 и 21 одно под другим.
        /// </summary>
        static void Exmpl13()
        {
            int a, b, c;
            a = 5; b = 10; c = 21;
            Console.WriteLine(a + "\n" + b + "\n" + c);
        }

        /// <summary>
        /// 8.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
        /// </summary>
        static void Exmpl014()
        {
            Console.WriteLine("Дайте расстояние в сантиметрах.Чтобы найти число полных метров в нем");
            Console.Write("Введите в сантиметрах: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double m = cm / 100;
            Console.WriteLine("m=" + m);
        }

        /// <summary>
        /// 14.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
        /// </summary>
        static void Exmpl15()
        {
            Console.WriteLine("Прошло 234 дня. Сколько полных недель прошло за этот период?");
            int wk = 234 / 7;
            Console.WriteLine("Прошло : " + wk + " недель");
        }
        /// <summary>
        /// 10.	Дано двузначное число. Найти:
        /// a.число десятков в нем; 
        /// b.число единиц в нем; 
        /// c.сумму его цифр; 
        /// d.произведение его цифр
        /// </summary>
        static void Exmpl16()
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1, n2;
            n1 = num / 10;
            n2 = num % 10;
            Console.WriteLine("a) " + n1 + "\n" + "b) " + n2);
            Console.WriteLine("c) " + (n1 + n2) + "\n" + "d) " + (n1 * n2));
        }
        /// <summary>
        /// 12.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
        /// </summary>
        static void Exmpl17()
        {
            Console.Write("Введите радиус круга: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double s1, s2;
            s1 = R * R * 3.14;
            s2 = a * a;
            if (s1 > s2) Console.WriteLine("плошадь больше у круга : " + s1);
            if (s1 < s2) Console.WriteLine("плошадь больше у квадрата: " + s2);
        }

        /// <summary>
        /// 13.	 Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
        /// </summary>
        static void Exmpl18()
        {
            Console.Write("Введите объем певого тела: ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите объем втрого тела: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите массу певого тела: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите массу второго тела: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            double p1, p2;
            p1 = m1 / v1;
            p2 = m2 / v2;
            if (p1 > p2) Console.WriteLine("плотность у певого тела больше: " + p1);
            if (p1 < p2) Console.WriteLine("плотность у второго тела больше: " + p2);
        }
        /// <summary>
        /// 14.	 Известны сопротивления двух несоединенных друг с другом участков 
        /// электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?
        /// </summary>
        static void Exmpl19()
        {
            Console.Write("Введите сопротивление R1: ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сопротивление R1: ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите напряжение U1: ");
            int u1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите напряжение U2: ");
            int u2 = Convert.ToInt32(Console.ReadLine());
            int i1, i2;
            i1 = r1 * u1;
            i2 = r2 * u2;
            if (i1 < i2) Console.WriteLine("Меньший ток в первом участке: " + i1);
            if (i1 > i2) Console.WriteLine("Меньший ток во втором участке: " + i2);
        }
        /// <summary>
        /// 16.	вычисления значения функции y= 7x2-3x+6 при любом значении x;
        /// </summary>
        static void Exmpl20()
        {
            int y, x;
            Console.WriteLine("y = 7x^2-3x+6");
            Console.Write("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("y=" + y);
        }
        /// <summary>
        /// 18.	Дана сторона квадрата. Найти его периметр.
        /// </summary>
        static void Exmpl21()
        {
            Console.Write("Введите сторону квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Периметр : " + (a * 4));

        }

        /// <summary>
        /// 17.	вычисления значения функции x= 12a2+7a-16 при любом значении а.
        /// </summary>
        static void Exmpl22()
        {
            int x, a;
            Console.WriteLine("x= 12a2+7a-16");
            Console.Write("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            x = 12 * a * a + 7 * a - 16;
            Console.WriteLine("x=" + x);
        }
        /// <summary>
        /// 19.	Дан радиус окружности. Найти ее диаметр.
        /// </summary>
        static void Exmpl23()
        {

            Console.Write("Введите радиус окружности: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Диаметр : " + (a * 2));

        }
        /// <summary>
        /// 20.	Считая, что Земля — идеальная сфера с радиусом R 6350 км, определить расстояние 
        /// до линии горизонта от точки с заданной высотой над Землей.
        /// </summary>
        static void Exmpl24()
        {
            double R = 6350;

            Console.Write("Введите высоту над Землей (в километрах): ");
            double h = Convert.ToDouble(Console.ReadLine());

            double distanceToHorizon = Math.Sqrt((2 * R * h) + (h * h));
            Console.WriteLine($"Расстояние до линии горизонта: {distanceToHorizon} километров");
        }
        /// <summary>
        /// 26.	Дано четырехзначное число. Найти: 
        /// a.сумму его цифр;  
        /// b.произведение его цифр

        /// </summary>
        static void Exmpl25()
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int x1, x2, x3, x4;
            x1 = num / 1000;
            x2 = (num - x1 * 1000) / 100;
            x3 = (num - x1 * 1000 - x2 * 100) / 10;
            x4 = num % 10;
            Console.WriteLine("сумма его цифр: " + (x1 + x2 + x3 + x4));
            Console.WriteLine("сумма его цифр: " + (x1 * x2 * x3 * x4));

        }
        /// <summary>
        /// 21.	вычисления значения функции z=x3-2.5xy+1.78x2-2.5y+1 при любых значениях х и y;
        /// </summary>
        static void Exmpl26()
        {
            double z, x, y;
            Console.WriteLine("z=x3-2.5xy+1.78x2-2.5y+1");
            Console.Write("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y: ");
            y = Convert.ToInt32(Console.ReadLine());

            z = x * x * x - 2.5 * x * y + 1.78 * x * x - 2.5 * y + 1;
            Console.WriteLine("z=" + z);
        }
        /// <summary>
        /// 39.	Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20
        /// </summary>
        static void Exmpl27()
        {
            Console.WriteLine("Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20");

            Console.WriteLine("20 20 20 20 20 20 20 20 20 20");
        }
        /// <summary>
        /// 42.	Напечатать таблицу умножения на 9: 9 х 1 = 9 9 х 2 = 18 ... 9 х 9 = 81
        /// </summary>
        static void Exmpl28()
        {
            for (int i = 1; i <= 9; i++)
            {
                int result = 9 * i;
                Console.WriteLine($"9 х {i} = {result}");
            }
        }
        /// <summary>
        /// 41.	Напечатать таблицу соответствия между весом в фунтах и весом в килограммах для значений 1, 2, ..., 10 фунтов (1 фунт = 453 г).
        /// </summary>
        static void Exmpl29()
        {
            Console.WriteLine("Фунты   | Килограммы");
            Console.WriteLine("-------------------");

            for (int фунты = 1; фунты <= 10; фунты++)
            {
                double килограммы = фунты * 0.453; // Перевод из фунтов в килограммы

                Console.WriteLine($"{фунты,-6} | {килограммы,-10:F3}");
            }
        }
        /// <summary>
        /// 30.	Даны два различных вещественных числа. Определить: 
        /// a.какое из них больше;
        /// b.какое из них меньше

        /// </summary>
        static void Exmpl30()
        {
            Console.Write("Введите первое число:");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число:");
            double number2 = double.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"Первое число ({number1}) больше второго числа ({number2}).");
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"Первое число ({number1}) меньше второго числа ({number2}).");
            }
            else
            {
                Console.WriteLine("Введенные числа равны.");
            }
        }
        /// <summary>
        /// 32.	Дано натуральное число. Определить: 
        /// a.является ли оно четным;
        /// b.оканчивается ли оно цифрой 7

        /// </summary>
        static void Exmpl31()
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            bool isEven = number % 2 == 0;
            bool endsWith7 = number % 10 == 7;

            if (isEven)
            {
                Console.WriteLine("Число является четным.");
            }
            else
            {
                Console.WriteLine("Число не является четным.");
            }

            if (endsWith7)
            {
                Console.WriteLine("Число оканчивается на цифру 7.");
            }
            else
            {
                Console.WriteLine("Число не оканчивается на цифру 7.");
            }
        }
        static void Main(string[] args)
        {
            Exmpl31();




        }
    }
}
