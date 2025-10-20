using Assignment_02_EF.Data;

namespace Assignment_02_EF
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
