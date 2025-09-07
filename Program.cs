﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace Calaculator
{
    internal class Program
    {
        private static double mem = 0;
        static void Main()
        {
            int perv, vtor, res;
            string znak;
            Console.WriteLine("Это калькулятор. Введите числа, а затем математический знак(+, -, *, /) или M+, M-,MR,sqrt,^2");
            Console.Write("Введите число: ");
            perv = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знак: ");
            znak = Console.ReadLine();
            if (znak == "+")
            {
                Console.Write("Введите второе число: ");
                vtor = System.Convert.ToInt32(Console.ReadLine());
                res = perv + vtor;
                Console.WriteLine("Сумма= " + res);
            }
            if (znak == "-")
            {
                Console.Write("Введите второе число: ");
                vtor = System.Convert.ToInt32(Console.ReadLine());
                res = perv - vtor;
                Console.WriteLine("Разность= " + res);
            }
            if (znak == "*")
            {
                Console.Write("Введите второе число: ");
                vtor = System.Convert.ToInt32(Console.ReadLine());
                res = perv * vtor;
                Console.WriteLine("Произведение= " + res);

            }
            if (znak == "/")
            {
                Console.Write("Введите второе число: ");
                vtor = System.Convert.ToInt32(Console.ReadLine());
                if (vtor == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                res = perv / vtor;
                Console.WriteLine("Деление= " + res);
            }
            if (znak == "^2")
            {
                Console.WriteLine("Квадрат числа= " + Math.Pow(perv, 2));
            }
            if (znak == "sqrt")
            {
                if (perv == 0)
                {
                    Console.WriteLine("Нельзя взять корень из 0");
                }
                Console.WriteLine("Корень числа= " + Math.Sqrt(perv));
            }
            if (znak == "M+")
            {
                mem += perv;
                Console.WriteLine("Добавлено в память, а память сейчас= " + mem);
            }
            if (znak == "M-")
            {
                mem -= perv;
                Console.WriteLine("Удалено из памяти, а память сейчас= " + mem);
            }
            if (znak == "MR")
            {
                Console.WriteLine("Память сейчас= " + mem);
            }


        }
    }
}