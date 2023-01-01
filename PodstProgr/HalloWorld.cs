using System;
using System.Collections.Generic;
using MyUtilities;

namespace PodstProgr
{
    class HalloWorld
    { 
        static void Main(string[] args)
        {
            WeatherUtilities.Report("Koszalin", WeatherUtilities.CnaF( 6) , 75);
            WeatherUtilities.Report("Słupsk", 23, 65);
            Console.WriteLine("Hallo World! " );


            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            int[] a = { 1, 2, 3 };
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }


        }

       //public class child : parent
       // public child (int x, int t): base (x, t)
       // public virtual void x - aby childy mogly miec swoja wersje
       //public override void x - child zmienia sobie 

        // public abstract class x{ public abstract void method();}

    }
}