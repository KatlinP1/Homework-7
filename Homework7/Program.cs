using System;

namespace Homework7
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal hamster=new Animal("Hamsu",0.1, 0,0);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Cycle {i+1}");
                hamster.Eat();

                while (hamster.weight > 0.7)
                {
                    hamster.Exercise();
                }
                
            }

            Console.WriteLine();
            Console.WriteLine($"I'm sorry, {hamster.name} died.");
            hamster= null;
            
            PrintHamster();
            Console.ReadLine();

        }

        //https://ascii.co.uk/art/hamster hamster Ascii art 
        public static void PrintHamster()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("           (>\\---/<)");
            Console.WriteLine("           ,'     `.");
            Console.WriteLine("          /  q   p  \\");
            Console.WriteLine("         (  >(_Y_)<  )");
            Console.WriteLine("         >-' `-' `-<-.");
            Console.WriteLine("        /  _.== ,=.,- \\");
            Console.WriteLine("       /,    )`  '(    )");
            Console.WriteLine("      ; `._.'      `--<");
            Console.WriteLine("     :     \\        |  )");
            Console.WriteLine("      \\      )       ;_/ ");
            Console.WriteLine("       `._ _/_  ___.'-\\\\\\");
            Console.WriteLine("          `--\\\\\\");
            
            Console.WriteLine($"In memorial of hamster. \n{DateTime.Now.Year} ");
        }
    }
}