using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_maschine
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage;
            string originalMessage;
            Console.WriteLine("Geben Sie die Nachrichten ein: ");
            string message = Console.ReadLine();


            Console.WriteLine("Geben Sie die Schlüssel ein: ");
            string keyword = Console.ReadLine();

            Console.WriteLine("Die verschlüsselte Nachricht ist : ");
            encryptedMessage = Cipher.Encipher(message, keyword);
            
            Console.WriteLine(encryptedMessage);

            Console.WriteLine();
            originalMessage = Cipher.Decipher(message, keyword);
            Console.WriteLine(originalMessage);
            //Save.SaveTo(encryptedMessage);
            //Console.WriteLine("Die gespeicherte Message ist :");
            //Console.WriteLine(Save.FileOpen());

            Console.ReadLine();

        }
    }
}
