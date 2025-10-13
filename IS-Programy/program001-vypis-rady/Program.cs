internal class Program
{
    private static void Main(string[] args)
    {
        string userChoice = "a";
        while (userChoice == "a")
        {
            Console.Clear();
            Console.WriteLine("************************************");
            Console.WriteLine("***********Výpis číselné řady*******");
            Console.WriteLine("************************************");
            Console.WriteLine("***********Eva Ježková**************");
            Console.WriteLine("************2.10.2025***************");
            Console.WriteLine("************************************");
            Console.WriteLine();

            //Vstup hodnoty do programu, ale špatně řešený
            //Console.Write("Zadejte první číslo první řady")
            //int first = int.Parse(Console.ReadLine());

            //Vstup do programu řešený lépe
            Console.Write("Zadejte první číslo řady(celé číslo):");

            int first;
            while (!int.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("Nezadali jste celé číslo. Zadejte první číslo řady znovu");
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            userChoice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        }
    }
}