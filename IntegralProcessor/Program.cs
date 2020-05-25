using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegralProcessor {

    
    class Program {
        //Область интегрирования
        static double left = 0;
        static double right = 10;
        static double f(double x) {//Интегрируемая функция
            return x * x * x - 5 * x * x; 
        }
        public static void Main(string[] args) {
            IntegralProcessor processor = new IntegralProcessor(f);
            //var time = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Первый способ: " + processor.RectangularI(left, right, 10000000));
            //time.Stop();
            //Console.WriteLine(time.ElapsedMilliseconds + " мс" );
            Console.WriteLine("Второй способ: " + processor.Monte_CarloI(left, right, 4, 500, -50 , 128));
            Console.WriteLine("Третий способ: " + processor.SimpsonI(left, right, 4));
            Console.ReadKey();
        }
    }
}
