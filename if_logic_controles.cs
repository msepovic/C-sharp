namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if its positive or negative: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (a > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
    }
}
