using System;

namespace loops
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
             simple for loop

           
            Console.WriteLine("enetr the value of numbers which you went");
            int a = int.Parse(Console.ReadLine());
            for(int i=0;i<a;i++)
            {
                Console.WriteLine(i);
            }
              */


            /*
             marksheet

             */
          
            
            Console.WriteLine("enetr the student name");
            string s1 = Console.ReadLine();
            Console.WriteLine("enetr the roll no:");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr the physics marks");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr the maths marks");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr the science marks");
            int ss = int.Parse(Console.ReadLine());
            Console.WriteLine("enetr the chemistry marks");
            int c = int.Parse(Console.ReadLine());

            int sum = p + m + ss + c;
            float per = (sum / 400f) * 100;

            if (per <= 90)
            {
                Console.WriteLine("you got A grade");
            }
            else if (per <= 80)
            {
                Console.WriteLine("you got B grade");
            }
            else if (per <= 70)
            {
                Console.WriteLine("you got C grade");
            }
            else if (per <= 60)
            {
                Console.WriteLine("you got D grade");
            }
            else if (per <= 50)
            {
                Console.WriteLine("you got E grade");
            }

            else
            {
                Console.WriteLine("fail");
            }
            Console.WriteLine("your name is {0}:",s1);
            Console.WriteLine("your roll no is is {0}:",r);
            Console.WriteLine("your total marks is:");
            Console.WriteLine(sum);
            Console.WriteLine("your percentage is:");
            Console.WriteLine(per);
            
        }
    }
    }


