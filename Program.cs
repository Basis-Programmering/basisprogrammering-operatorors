namespace basisprogrammering_operatorors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");

            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("results of maths:");
            Console.WriteLine($"a + b =  {a + b}");
            Console.WriteLine($"a - b =  {a - b}");
            Console.WriteLine($"a * b =  {a * b}");
            Console.WriteLine($"a / b =  {a / b}");
            Console.WriteLine($"(a + b)*2 =  {(a+b)*2}");
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
