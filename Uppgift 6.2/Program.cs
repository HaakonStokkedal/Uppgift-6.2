namespace Uppgift_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till heltal:");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{StörstaTal(tal1, tal2)} är det största talet.");

            Console.ReadKey();
        }

        static int StörstaTal(int tal1, int tal2)
        {
            int störstaTal = tal1;

            if (tal1 < tal2)
            {
                störstaTal = tal2;
            }
            return störstaTal;
        }
    }
}