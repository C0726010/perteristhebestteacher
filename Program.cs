using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0726010
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();

            dogs.Add("Bulldog");
            dogs.Add("pitbull");
            dogs.Add("huskey");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + " ");

            }


            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };
            foreach (int i in a1)
            {
                Console.WriteLine("the value of  i " + " ");
            }
        }
    }
}
