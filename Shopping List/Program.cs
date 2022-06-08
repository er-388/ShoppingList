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
            string polku = @"C:\Users\Erkki\source\repos\Shopping List\Shopping List\text.txt";

            //List<string> tuotteet = new List<string>();

            Console.Write("Kirjoita tuote lisättäväksi ostoslistaan: ");
            string syote = Console.ReadLine();

            if (File.Exists(polku))
            {
                File.WriteAllText(polku, syote + Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Tiedostoa ei ole olemassa!");
            }
            




        }
    }
}
