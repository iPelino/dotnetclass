using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*var operation1 = new Calculate();
            Console.WriteLine("Enter first number");
            var num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            var num2 = Convert.ToDouble(Console.ReadLine());
          
         
            Console.WriteLine("the sum of {0} and {1} is equal to {2}",
                num1,num2, operation1.Add(num1, num2));

            Console.ReadKey();*/

            var car0 = new Cars();
            car0.Color = "Yellow";

            var car1 = new Cars(50,"black",2018);
            var car2 = new Cars(70,"red",2008);
            var car3 = new Cars(65,"Silver",2010);
            Console.WriteLine(car3.Year);
            Console.ReadKey();




        }

        
    }

}
