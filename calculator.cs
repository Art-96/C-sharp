using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number: ");
                string a = Console.ReadLine();
                int number;
                bool result = int.TryParse(a, out number);
                if (result)
                {
                    Console.WriteLine("Enter the arithmetic command: ");
                    string str = Console.ReadLine();

                    Console.WriteLine("Enter the second number: ");
                    string b = Console.ReadLine();
                    int number2;
                    bool result2 = int.TryParse(b, out number2);
                    if (result2)
                    {
                        if (str == "+")
                        {
                            Console.WriteLine("Answer:" + (number + number2));
                        }
                        else if (str == "-")
                        {
                            Console.WriteLine("Answer:" + (number - number2));
                        }
                        else if (str == "*")
                        {
                            Console.WriteLine("Answer:"+(number * number2));
                        }
                        else if (str == "/")
                        {
                            Console.WriteLine("Answer:"+(number / number2));
                        }
                        else
                        {
                            Console.WriteLine("You entered an invalid character!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered incorrectly!");
                        continue;
                    }

                    
                }
                else
                {
                    Console.WriteLine("You entered incorrectly!");
                    continue;
                }

                
            }
        }
    }


}
