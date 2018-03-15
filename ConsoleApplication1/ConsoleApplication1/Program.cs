using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            Console.WriteLine("請輸入身高");
            Console.WriteLine("請輸入體重");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            double a = double.Parse(input2) / (double.Parse(input1) / 100 * double.Parse(input1) / 100);

            
            


            Console.WriteLine("BMI="+Math .Round ( a));
            Console.Read();

            
        }
    }
}
