using System;

namespace Uppgift_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar2;
            bool slut = false;
            int stor = 0;
            int tal;

           
            while (slut == false)
            {
                try
                {
                    Console.WriteLine("Vill du skriva in ett till heltal?");
                    svar2 = Console.ReadLine();
                    if (svar2 == "J")
                    {
                        Console.WriteLine("Skriv ett heltal");
                        tal = int.Parse(Console.ReadLine());
                        if (tal > stor)
                        {
                            stor = tal;
                        }
                    }
                    
                    if (svar2 == "N")
                    {
                        Console.WriteLine("Ditt svar är " + stor);
                        slut = true;
                        Console.ReadKey();
                    } 

                }
                catch 
                { 
                    Console.WriteLine("FEL");
                }



            }
            


        }
    }


}