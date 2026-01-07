using System;

class Program
{
    static void Main()
    {
        // Generátor náhodných čísel
        Random rnd = new Random();
        string hratZnovu = "a";

        while (hratZnovu == "a")
        {
            Console.Clear();
            // Nastavení hry: délka chodby, pozice východu a energie hráče
            int delkaChodby = 15;
            int vychod = rnd.Next(5, delkaChodby); 
            int poziceHrace = 0;
            int energie = 10;
            bool vyhra = false;

            Console.WriteLine("====================================");
            Console.WriteLine("********** ÚTĚK Z BLUDIŠTĚ *********");
            Console.WriteLine("====================================");
            Console.WriteLine("Najdi východ (X), než ti dojde energie!");

            // Hlavní herní smyčka
            while (energie > 0 && !vyhra)
            {
                Console.WriteLine($"\nEnergie: {energie} | Tvoje pozice: {poziceHrace}");
                
                // Vizualizace chodby (P = Hráč, . = cesta)
                for (int i = 0; i < delkaChodby; i++)
                {
                    if (i == poziceHrace) 
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("P "); 
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(". ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();

                // Vstup od hráče
                Console.Write($"Kam skočíš? (zadej 0 až {delkaChodby - 1}): ");
                string vstup = Console.ReadLine();
                
                if (int.TryParse(vstup, out int novaPozice))
                {
                    if (novaPozice >= 0 && novaPozice < delkaChodby)
                    {
                        poziceHrace = novaPozice;
                        energie--; // Každý skok stojí 1 energii

                        if (poziceHrace == vychod) 
                        {
                            vyhra = true;
                        }
                        else 
                        {
                            // Nápověda směru
                            if (poziceHrace < vychod) Console.WriteLine("-> Cítíš průvan zprava!");
                            else Console.WriteLine("<- Průvan fouká zleva!");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Mimo chodbu! Ztrácíš čas i energii.");
                        energie--;
                    }
                }
                else
                {
                    Console.WriteLine("Zadej prosím celé číslo!");
                }
            }

            // Vyhodnocení konce hry
            if (vyhra)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n🎉 GRATULACE! Našel jsi východ a jsi volný!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n💀 Energie došla. Zůstal jsi v bludišti navždy...");
            }
            Console.ResetColor();

           Console.Write("\nChceš hrát znovu? (a/n): ");
            hratZnovu = Console.ReadLine()?.ToLower() ?? "n";
        } // Tato závorka končí while (cyklus hry)

        // Tady program čeká, než se okno zavře
        Console.WriteLine("\nHra skončila. Stiskni libovolnou klávesu pro zavření okna...");
        Console.ReadKey();

    } // Tato závorka končí Main (hlavní část)
} // Tato závorka končí Program (celý soubor)