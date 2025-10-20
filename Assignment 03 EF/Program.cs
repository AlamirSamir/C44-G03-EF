using Assignment_03_EF.Data;

namespace Assignment_03_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDOperations.PerformCRUDAndTestRelations();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
