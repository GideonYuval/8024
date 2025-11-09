using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8024
{
    //1. Draw Diagram
    //2. What will be printed
    internal class Program
    {
        static void Main(string[] args)
        {
            new AAA(2);
            new BBB(3);
        }
    }

    public class AAA
    {
        public AAA()
        {
            Console.WriteLine("AAA ctor!");
        }
        public AAA(int num)
        {
            if (num > 0) new AAA(num - 1);
                else new AAA();
            Console.WriteLine("AAA ctor" + num);
        }
    }
    public class BBB : AAA
    {
        public BBB() : base()
        {
            Console.WriteLine("BBB ctor!");
        }
        public BBB(int num) : base(num)
        {
            new AAA(num / 2);
            new BBB();
            Console.WriteLine("BBB ctor" + num);
        }
    }
}
