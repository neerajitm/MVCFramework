using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        object[] array = null;
        

        public void test()
        {
            array = new object[10];
            array[0] = 1;
            array[1] = "Ashish";
            array[2] = 10.5;
            //int.Parse(null);
                
            foreach (var arr in array)
            {
                Console.WriteLine(arr);
            }

        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.test();
            Console.ReadLine();
        }
    }

    //public class Sample
    //{
    //    private int a;
    //}
}
