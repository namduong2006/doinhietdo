using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double doC,doF;
            int choice;
            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1.Đổi độ C sang độ F.");
                Console.WriteLine("2.Đổi độ F sang độ C.");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Nhập lựa chọn.");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhập nhiệt độ (C)");
                        doC = double.Parse(Console.ReadLine());
                        Console.WriteLine(cToF(doC)+"(Độ F)");
                        break;
                    case 2:
                        Console.WriteLine("Nhập nhiệt độ (F)");
                        doF = double.Parse(Console.ReadLine());
                        Console.WriteLine(fToC(doF)+"(Độ C)");
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;


                }
            }
            while (choice != 0);
            Console.ReadLine();
            
        }
        public static double cToF(double c)
        {
            double f = (9.0 / 5) * c + 32;
            return f;
        }
        public static double fToC(double f)
        {
            double c = (f - 32) * (5.0 / 9);
            return c;
        }

    }
}
