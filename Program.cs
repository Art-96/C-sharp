using System;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Введите число: ");
                string num = Console.ReadLine();
                int a;
                bool v1 = int.TryParse(num, out a);
                if (v1)
                {
                    string str2 = "";


                    if (a / 1000000000 > 0)
                    {
                        str2 += Calculate(a / 1000000000) + " միլիարդ ";
                    }
                    if ((a / 1000000) % 1000 > 0)
                    {
                        str2 += Calculate((a / 1000000) % 1000) + " միլիոն ";
                    }
                    if ((a / 1000) % 1000 > 0)
                    {
                        str2 += Calculate((a / 1000) % 1000) + " հազար ";
                    }
                    if (a % 1000 > 0)
                    {
                        str2 += Calculate(a % 1000);
                    }

                    Console.WriteLine(str2);
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильно !");
                }
            }

        }
        static private string Calculate(long n)
        {
            long a = n;
            string str = "";

            if (a / 100 < 10 && a / 100 > 0)
            {
                switch (a / 100)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            str += " երկու";
                            break;
                        }
                    case 3:
                        {
                            str += " երեք";
                            break;
                        }
                    case 4:
                        {
                            str += " չորս";
                            break;
                        }
                    case 5:
                        {
                            str += " հինգ ";
                            break;
                        }
                    case 6:
                        {
                            str += " վեց ";
                            break;
                        }
                    case 7:
                        {
                            str += " յոթ";
                            break;
                        }
                    case 8:
                        {
                            str += " ութ";
                            break;
                        }
                    case 9:
                        {
                            str += " ինը";
                            break;
                        }
                }
                a = a % 100;
                str += " հարյուր ";
            }
            if (a / 10 < 10 && a / 10 > 0)
            {
                switch (a / 10)
                {
                    case 1:
                        {
                            str += a % 10 == 0 ? " տասը" : " տասն";
                            break;
                        }
                    case 2:
                        {
                            str += " քսան";
                            break;
                        }
                    case 3:
                        {
                            str += " երեսուն";
                            break;
                        }
                    case 4:
                        {
                            str += " քառասուն";
                            break;
                        }
                    case 5:
                        {
                            str += " հիսուն";
                            break;
                        }
                    case 6:
                        {
                            str += " վաթսուն";
                            break;
                        }
                    case 7:
                        {
                            str += " յոթանասուն";
                            break;
                        }
                    case 8:
                        {
                            str += " ութանասուն";
                            break;
                        }
                    case 9:
                        {
                            str += " ինսուն";
                            break;
                        }
                }
                a = a % 10;
            }
            switch (a)
            {
                case 1:
                    {
                        str += " մեկ";
                        break;
                    }
                case 2:
                    {
                        str += " երկու";
                        break;
                    }
                case 3:
                    {
                        str += " երեք";
                        break;
                    }
                case 4:
                    {
                        str += " չորս";
                        break;
                    }
                case 5:
                    {
                        str += " հինգ";
                        break;
                    }
                case 6:
                    {
                        str += " վեց";
                        break;
                    }
                case 7:
                    {
                        str += " յոթ";
                        break;
                    }
                case 8:
                    {
                        str += " ութ";
                        break;
                    }
                case 9:
                    {
                        str += " ինը";
                        break;
                    }
            }
            return str;
        }
    }


}
