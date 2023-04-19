namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(TempConverter.FarenheitToCelsius(90));
            Console.WriteLine(TempConverter.CelsiusToFarenheit(23));
        }
    }
}