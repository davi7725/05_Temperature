using System;

namespace _05_Temperature
{
    enum Unit
    {
        Celcius,
        Fahrenheit
    }



    internal class Temperature
    {

        public int Fahrenheit;
        public int Celcius;

        public Temperature()
        {

        }
        
        public Temperature(Unit type,int value)
        {
            if(type == Unit.Celcius)
            {
                Celcius = value;
            }
            else
            {
                Fahrenheit = value;
            }
        }
        internal static double FahrenheitToCelcius(double v)
        {
            return (v - 32) * 5 / 9;
        }

        internal static double CelciusToFahrenheit(double v)
        {
            return v * 9 / 5 + 32;
        }

    }
}