using System;
using System.Collections.Generic;
using System.Text;

namespace MyUtilities
{
    public class WeatherUtilities

    {
        

      
        public static float FnaC(float tempF)
        {
            //można var użyć
            return (tempF - 32) / 1.8f;
        }

        public static float CnaF(float tempC)
        {
            //można var użyć
            return tempC * 1.8f + 32;
        }

        /*
         * Komentarz
         */
        public static float ComfortIndex(float tempF, float humidityPercent)
        {
            //Komentarz
            return (tempF + humidityPercent) / 4;

        }
        public static void Report(string location, float tempC, float humidity)
        {
            var tempF = CnaF(tempC);
            Console.WriteLine($"Comfort index for {location}; {ComfortIndex(tempF, humidity)}");
            //prawy+1opcja+string interpolacja w celu zamiany całego kodu na stringa

        }
    }
}
