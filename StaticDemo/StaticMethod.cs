//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StaticDemo
//{
//    class StaticMethod
//    {
//        static StaticMethod()
//        {
//            Console.WriteLine("static constructor is called");
//        }
//        public StaticMethod()
//        {
//            Console.WriteLine("non-static constructor is called");
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Main method is executed");
//            StaticMethod obj1 = new StaticMethod();
//            StaticMethod obj2 = new StaticMethod();
//            Console.WriteLine("Press any key to exit.");
//            Console.ReadLine();
//        }
//    }
//}
