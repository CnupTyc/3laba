using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("\nНаучный калькулятор:\n");
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("\n1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Извлечение корня");
            Console.WriteLine("7. Вычисление синуса");
            Console.WriteLine("8. Вычисление косинуса");
            Console.Write("9. Выход\n");
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Menu();
                string str = Console.ReadLine();
                Calculator_ m = new Calculator_();
                double a, b, c;

                switch (str)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\n Введите 2 числа:");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        c = m.Sum(a, b);
                        Console.Write("\n");
                        Console.Write(a);
                        Console.Write(" + ");
                        Console.Write(b);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n Введите 2 числа:");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        c = m.Sub(a, b);
                        Console.Write("\n");
                        Console.Write(a);
                        Console.Write(" - ");
                        Console.Write(b);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("\n Введите 2 числа:");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        c = m.Mul(a, b);
                        Console.Write("\n");
                        Console.Write(a);
                        Console.Write(" * ");
                        Console.Write(b);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("\n Введите 2 числа:");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        c = m.Div(a, b);
                        Console.Write("\n");
                        Console.Write(a);
                        Console.Write(" / ");
                        Console.Write(b);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("\n Введите число и степень:");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        c = m.Stepen(a, b);
                        Console.Write("\n");
                        Console.Write(a);
                        Console.Write("^");
                        Console.Write(b);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("\n Введите число и степень корня:");
                        a = Convert.ToDouble(Console.ReadLine());
                        do { b = Convert.ToDouble(Console.ReadLine()); } while (b < 0);
                        Console.Clear();
                        c = m.Sqrt(a, b);
                        Console.Write("\n Корень ");
                        Console.Write(a);
                        Console.Write(" в степени ");
                        Console.Write(b);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("\n Введите число:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        c = m.Sin(a);
                        Console.Write("\n sin ");
                        Console.Write(a);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("\n Введите число:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        c = m.Cos(a);
                        Console.Write("\n cos ");
                        Console.Write(a);
                        Console.Write(" = ");
                        Console.Write(c);
                        Console.Write("\n\n");
                        break;

                    case "9":
                        Console.Clear();
                        break;
                }
                Console.Write("Для продолжения работы нажмите Enter, для выхода любую клавишу...");
            } while (Convert.ToInt32(Console.ReadKey().Key) == 13);
        }
    }
}
