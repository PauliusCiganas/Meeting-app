using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_app
{
    public class Utility
    {

        public static int getStringFromArray(string[] array, string question)
        {
            bool exit = false;
                int result = 0;
            Console.WriteLine(question);

            while (!exit)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i, array[i]);
                }
                if (!int.TryParse(Console.ReadLine(), out result) || result > array.Length - 1 || result < 0)
                {
                    Console.WriteLine("there's only so many selections buddy, try again...");
                    continue;
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
            return result;
        }
    }
}
