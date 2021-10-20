using System;

namespace stringOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "shivam";
            string s2 = "shivam";

            /*string s3 = s1 + s2;
            Console.WriteLine("the string is ");
            Console.WriteLine(s3);*/


            /*string s3 = String.Concat(s1, s2);
            Console.WriteLine("the string is ");
            Console.WriteLine(s3);*/

            /*  Console.WriteLine("s1={0}", s1);
              Console.WriteLine("s2={0}", s2);*/

            /*Console.WriteLine("s1==s2: {0}", s1 == s2);*/
            /*string val;
            int numb;
            Console.WriteLine("enter the numbers");
                val = Console.ReadLine();
            numb = Convert.ToInt32(val);
            Console.WriteLine(val);*/
            var a = new[] { 1, 2, 3, 4, 5, 6 };
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            
            Console.ReadLine();
        }
    }
}
