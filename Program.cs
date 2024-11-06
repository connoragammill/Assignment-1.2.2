namespace Assignment_1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("The first 10 natural numbers are:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine("\nThe Sum is: " + sum);
        }
    }
}
