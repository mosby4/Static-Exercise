using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		/*public static TempConverter()
		{
		}*/

		public static double FarenheitToCelsius(double input1)
		{
			
			return (input1 -32) / 1.8;
        }

        //
        public static double CelsiusToFarenheit(double input1)
		{
            //°F =°C * 1.8000+ 32.00
            return (input1 * 1.8) +32;

        }
    }
}

