using System.Text;

namespace CA230403
{
    internal class Program
    {
        static void Main()
        {
            using StreamWriter sw = new(path: 
                "valami.txt", 
                append: false, 
                encoding: Encoding.UTF8);

            DateTime birthDate = new(2005, 12, 12);
            string name = "Digruber Eszter";

            sw.WriteLine($"Hello, my name is {name}, " +
                $"I was born {DateTime.Today.Year - birthDate.Year} years ago.");

            Console.WriteLine("done!");
        }
    }
}