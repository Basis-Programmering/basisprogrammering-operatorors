namespace basisprogrammering_operatorors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Indtast b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Indtast c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Startværdi for a = {a}");
            double x = a; // arbejdskopi af a
            Console.WriteLine($"Arbejdskopi x = {x}");
            Console.WriteLine();

            // a) +=
            double before = x;
            x += b; // x = x + b
            Console.WriteLine($"Efter x += b :   {before} + {b} = {x}");

            // b) -=
            before = x;
            x -= c; // x = x - c
            Console.WriteLine($"Efter x -= c :   {before} - {c} = {x}");

            // c) *=
            before = x;
            x *= b; // x = x * b
            Console.WriteLine($"Efter x *= b :   {before} * {b} = {x}");

            // d) /=
            before = x;
            x /= c; // x = x / c
            Console.WriteLine($"Efter x /= c :   {before} / {c} = {x}");

            Console.WriteLine();
            Console.WriteLine("(Parentes-eksempler)");
            Console.WriteLine($"(a + b) * c = {(a + b) * c}");
            Console.WriteLine($"a + (b * c) = {a + (b * c)}");

            Console.WriteLine("\nTryk en tast for at afslutte...");
            Console.ReadKey(true);

        }
    }
}
