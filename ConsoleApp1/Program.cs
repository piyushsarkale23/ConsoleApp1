using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            uint balance = 2000;
            string name = "Rohan";
            int number = -100;
            long number2 = 9898989876;
            float percentage = 78.55F;
            double num1 = 876.65;
            DateTime dt = DateTime.Now;

            
            Console.WriteLine("my percentage is " + percentage);
            Console.WriteLine("my number is" + num1);
            Console.WriteLine("my percentage is {0}", percentage);
            Console.WriteLine($"my percentage is {percentage}");
            Console.WriteLine("my number is {0}", num1);
            Console.WriteLine($"my number is {num1}");
            Console.WriteLine("my name is" + name);
            Console.WriteLine("My name is{0}", name);
            Console.WriteLine($"my name is {name}");
            Console.WriteLine("My char is" + ch);
            Console.WriteLine("My char is{0}", ch);
            Console.WriteLine("My balance is" + balance);
            Console.WriteLine("My balance is{0}", balance);
            Console.WriteLine("enter your name");
            string username = Console.ReadLine();
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("enter your percentage");
            float percent = Convert.ToSingle( Console.ReadLine() );
            Console.WriteLine("enter a character:-");
            char ch2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter a long number:-");
            long numm = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter a double value");
            double val = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("enter a decimal value");
            decimal val1 = Convert.ToDecimal( Console.ReadLine() );
            Console.WriteLine("enter a positive number");
            uint val2 = Convert.ToUInt32( Console.ReadLine() );
            Console.WriteLine("enter a boolean value");
            bool val3 = Convert.ToBoolean( Console.ReadLine() );
            Console.WriteLine("enter Date and time");
            DateTime dtt = Convert.ToDateTime( Console.ReadLine() );
            Console.WriteLine($"Username is {username} and age is {age} and percentage is {percent} and character is {ch2} number is {numm} and value is {val} and secomd value is {val1} and third value is{val2} and fourth value is {val3} and date and time is {dtt} ");
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int b = Convert.ToInt32(Console.ReadLine()); 

            int sum = a + b;
            Console.WriteLine("The sum is :-" + sum);

            int sub = a - b;
            Console.WriteLine("The subtraction is:- "+ sub);

            int multiply = a * b;
            Console.WriteLine("The multiplication is:- " + multiply);

            double divide = (double)a / b;   
            Console.WriteLine("division is:- " + divide);

            int mod = a % b;
            Console.WriteLine("mod is:- " + mod);
            
            int a2 = 10, b2= 20, c = 30, d = 40;
            a2 += 10;  // a=a+10 = 20;
            b2 -= 5;  // b=b-5 =15
            c *= 5;  // c=c*5 = 150
            d /= 2; // d=d/2 = 20
            Console.WriteLine($"value of a {a2}");
            Console.WriteLine($"value of b {b2}");
            Console.WriteLine($"value of c {c}");
            Console.WriteLine($"value of d {d}");


            int e = 9, f = 9;

            Console.WriteLine(e < f); // 9<9 
            Console.WriteLine(e <= f); // 9<=9
            Console.WriteLine(e > f);  // 10>9
            Console.WriteLine(e >= f); //10 >=9
            Console.WriteLine(e == f); // 10==9
            Console.WriteLine(e != f); // 10!=9


            Console.WriteLine("enter first number:- ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Second number:- ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            int sum1 = a1 + b1;
            Console.WriteLine("The sum is " + sum1);
            Console.WriteLine("date and time is " + dt);





        }
    }
}
