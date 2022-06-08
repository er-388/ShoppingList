using System;
using System.Collections.Generic;
using System.IO;
/*Asks user one shoppping item
* Saves input to a file
*  Hint: append
*  
*  Bonus: On startup, print all items from the file*/
namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string polku = @"C:\Users\Erkki\source\repos\Shopping List\Shopping List\data.txt";

            //List<string> tuotteet = new List<string>();
            string[] tuotteet;
            if (File.Exists(polku))
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
            
        }
    }
}

