//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StaticDemo
//{
//    class Program
//    {
//        int x; // Non statuc variable
//        static int y = 200; //Static Variable
//        public Program(int x)
//        {
//            this.x = x;
//            y =10;
//            Console.WriteLine("" + y);
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("" + y);
//            //Accessing the static variable using class name
//            //Before object creation
//            Console.WriteLine("Static Variable Y = " + Program.y);
//            //Creating object1
//            Program obj1 = new Program(50);
//            //Creating object2
//            Program obj2 = new Program(100);
//            Console.WriteLine($"object1 x = {obj1.x}  object2 x = {obj2.x}");
//            Console.WriteLine("Press any key to exit.");
//            Console.ReadLine();
//        }
//    }
//}
