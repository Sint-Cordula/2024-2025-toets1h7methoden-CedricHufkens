using System.Net.NetworkInformation;

namespace Toets1H7Methoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VEEL SUCCES! 

            //declareren variabelen
            int aantalKarakters, pincode; 
            
            //DEEL 1: pincode genereren
            Console.WriteLine("##### GENEREER PINCODE #####\n");

            //opvragen uit hoeveel cijfers de pincode moet bestaan
            Console.WriteLine("Uit hoeveel cijfers moet het wachtwoord bestaan?");
            aantalKarakters = Convert.ToInt32 (Console.ReadLine());

            //pincode genereren op basis van zelf geschreven methode
            pincode = GetPincode(aantalKarakters);

            Console.WriteLine($"\nUw pincode: {pincode}\n");

            //DEEL 2: aanmelden
            Console.WriteLine("##### AANMELDEN MET PINCODE #####\n");

            //pincode opvragen
            Console.Write("Geef uw pincode op: ");
            int pincodeTest = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine();

            //pincode controleren
            if (Aanmelden(pincode, pincodeTest))
            {
                Console.WriteLine("U bent succesvol aangemeld.");
            }
            else
            {
                Console.WriteLine("Foutieve pincode. Toegang geweigerd.");
            }

        }
        public static int GetPincode(int aantalKarakters)
        {
            string pin=  "";
            int tel = 0;
            Random rand = new Random();
            for (int i = 0; i < aantalKarakters; i++)
            {
                tel = rand.Next(0, 10);
                pin += tel.ToString();
                

            }
            int pin1 = Convert.ToInt32(pin);
            return pin1;
        }
        public static bool Aanmelden(int pincode,int pincodeTest)
        {
            bool result= false;
            if (pincode==pincodeTest)
            {
               result= true;
            }
            return result;

        }

    }
}
