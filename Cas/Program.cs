using System;


namespace Cas
{
    class Program
    {
        static void Main(string[] args)
        {
            Program instanca = new Program();

            string oper;

            do
            {
                Console.Write("Unesi prvi broj > ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Unesi drugi broj > ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Unesi zeljenu operaciju (+, -, *, /, ostavi prazno za zavrsetak) >");
                oper = Console.ReadLine();
                if (oper != "")
                {
                    int rezultat = instanca.Digitron(num1, num2, oper);
                    Console.WriteLine("Rezultat {0} {1} {2} = {3} ", num1, oper, num2, rezultat);
                }

            } while (oper != "");

            Console.ReadKey();
        }


        public int Digitron(int a, int b, string operacija)
        {
            int rezultat = 0;
            if (operacija == "+")
            {
                rezultat = a + b;
            }
            else if (operacija == "-")
            {
                rezultat = a - b;
            }
            else if (operacija == "/")
            {
                rezultat = a / b;
            }
            else if (operacija == "*")
            {
                rezultat = a * b;
            }
            return rezultat;
        }
    }
}
