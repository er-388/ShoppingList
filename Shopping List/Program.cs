using System;
using System.Collections.Generic;
using System.IO;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string polku = @"C:\Users\Erkki\source\repos\Shopping List\Shopping List\data.txt";

            
            string[] tuotteet;
            if (File.Exists(polku)) //jos tiedosto löytyy, lisätään rivit string arrayhyn ja tulostetaan tuotteet
            {
                tuotteet = File.ReadAllLines(polku);
                Console.WriteLine("Aiemmin lisätyt tuotteet: ");
                foreach (string tuote in tuotteet)
                {
                    Console.WriteLine(tuote);
                }

                Console.WriteLine();
            }

            Console.Write("Kirjoita tuote lisättäväksi ostoslistaan: ");
            string syote = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(syote))
            {
                File.AppendAllText(polku, syote + Environment.NewLine);
                Console.WriteLine("Lisäsit tuotteen " + syote);
            }
            Console.WriteLine("Testituloste");//mergen testaamista varten
            
        }
    }
}

