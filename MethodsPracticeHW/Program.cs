using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPracticeHW
{
    class Program
    {
        static void Main(string[] args)
        {    //slides 1 and 2

            SayHello("John");
            SayGoodbye("John");

            //slide 3

            Console.WriteLine("The sum of your numbers is " + SumIt(1142134132, 323423));


            //slide 4
            //int[] array = { 20, 33, 44, 89 };
            //Console.WriteLine("The sum of the example array is " + SumArrayIt(array));

            //slide 5

            Console.WriteLine(DoubleIt(22));

        }

        // start METHODS - slides and 2

        public static string SayHello(string name)
        {
            Console.WriteLine("Hello " + name + "!");
            return name;
        }

        public static string SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye " + name + "! :)");
            return name;
        }

        //slide 3

        public static int SumIt(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        //slide 4

        //public static int SumArrayIt(int fNum, int sNum, int tNum, int fNum)

        //{
        //    int[] newSum = fNum + sNum + tNum + fhNum;
        //    return newSum;
        //}
            // slide 5
        
        public static int DoubleIt(int doubleNumber)
        {
            int doubleNum = 2*doubleNumber;
            return doubleNum;
        }

    }
}