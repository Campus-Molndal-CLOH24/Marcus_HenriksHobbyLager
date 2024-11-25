﻿using HenriksHobbyLager.Interfaces;

namespace HenriksHobbyLager.UI
{
    internal class ConsoleMenuHandler
    {
        public static void RunMenu(IProductFacade productFacade)
        {
            // Huvudloopen - Stäng inte av programmet, då försvinner allt!
            while (true)
            {
                Console.Clear();  // Rensar skärmen så det ser proffsigt ut
                Console.WriteLine("=== Henriks HobbyLager™ 1.0 ===");
                Console.WriteLine("1. Visa alla produkter");
                Console.WriteLine("2. Lägg till produkt");
                Console.WriteLine("3. Uppdatera produkt");
                Console.WriteLine("4. Ta bort produkt");
                Console.WriteLine("5. Sök produkter");
                Console.WriteLine("6. Avsluta");  // Använd inte denna om du vill behålla datan!

                var choice = Console.ReadLine();

                // Switch är tydligen bättre än if-else enligt Google
                switch (choice)
                {
                    case "1":
                        //productFacade.GetAllProducts(); 
                        break;
                    case "2":
                        //productFacade.CreateProduct();
                        break;
                    case "3":
                        //productFacade.UpdateProduct();
                        break;
                    case "4":
                        //productFacade.DeleteProduct();
                        break;
                    case "5":
                        //productFacade.SearchProducts();
                        break;
                    case "6":
                        return;  // OBS! All data försvinner om du väljer denna!
                    default:
                        Console.WriteLine("Ogiltigt val! Är du säker på att du tryckte på rätt knapp?");
                        break;
                }

                Console.WriteLine("\nTryck på valfri tangent för att fortsätta... (helst inte ESC)");
                Console.ReadKey();
            }
        }
    }
}
