﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Schluesselung
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage;
            Console.WriteLine("Geben Sie die Nachrichten ein: ");
            string message = Console.ReadLine();


            Console.WriteLine("Geben Sie die Schlüssel ein: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Die verschlüsselte Nachricht ist : ");
            encryptedMessage = Cipher.Encipher(message, key);
            Console.WriteLine(encryptedMessage);
            Save.SaveTo(encryptedMessage);
            Console.WriteLine("Die gespeicherte Message ist :");
            Console.WriteLine(Save.FileOpen()); 

            Console.ReadLine();

        }

        
    }
}