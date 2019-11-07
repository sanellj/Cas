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
            {`
                    rezultat = a / b;
            }
            else if (operacija == "*")
            {
                rezultat = a * b;
            }
            return rezultat;



            // jedan zadatak sa koriscenjem konstante
            // Izracunavanje povrsine kruga
                        
                //const double pi = 3.1415;
                //double r;

                //Console.WriteLine("Unesi precnik");
                //r = Convert.ToDouble(Console.ReadLine());


                //double povrsina = pi * r * r;
                //Console.WriteLine("Precnik: {0}, Povrsina {1}", r, povrsina);
                //Console.ReadKey();
            




        }
    }
}
