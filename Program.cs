namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
            var aplicatie = new Aplicatie();
            
            aplicatie.Start();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}