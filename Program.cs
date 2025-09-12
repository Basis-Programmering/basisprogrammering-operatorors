namespace basisprogrammering_operatorors
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            // Vare 1
            Console.Write("Vare 1 navn: ");
            string n1 = Console.ReadLine();
            Console.Write("Pris pr. stk: ");
            decimal p1 = decimal.Parse(Console.ReadLine());
            Console.Write("Antal: ");
            int q1 = int.Parse(Console.ReadLine());

            // Vare 2
            Console.Write("\nVare 2 navn: ");
            string n2 = Console.ReadLine();
            Console.Write("Pris pr. stk: ");
            decimal p2 = decimal.Parse(Console.ReadLine());
            Console.Write("Antal: ");
            int q2 = int.Parse(Console.ReadLine());

            // Vare 3
            Console.Write("\nVare 3 navn: ");
            string n3 = Console.ReadLine();
            Console.Write("Pris pr. stk: ");
            decimal p3 = decimal.Parse(Console.ReadLine());
            Console.Write("Antal: ");
            int q3 = int.Parse(Console.ReadLine());

            // Linjetotaler og samlet total
            decimal t1 = p1 * q1;
            decimal t2 = p2 * q2;
            decimal t3 = p3 * q3;
            decimal total = t1 + t2 + t3;
            decimal udenMoms = total / 1.25m;

            // Udskrift (simple kolonner)
            Console.WriteLine("=== KVITTERING ===");
            Console.WriteLine("\nVare               Antal     Pris     Total");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{n1,-18}{q1,6}{p1,10:0.00}{t1,10:0.00}");
            Console.WriteLine($"{n2,-18}{q2,6}{p2,10:0.00}{t2,10:0.00}");
            Console.WriteLine($"{n3,-18}{q3,6}{p3,10:0.00}{t3,10:0.00}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{"Samlet total:",-24}{total,16:0.00}");
            Console.WriteLine($"{"Uden moms:",-24}{udenMoms,16:0.00}");

            Console.WriteLine("\nTryk en tast for at afslutte...");
            Console.ReadKey(true);


        }
    }
}
