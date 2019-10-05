using System;

namespace Kivi.Paber.Kaarid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tere tulemast! Olete asunud mängima mängu - \n" +
                "Kivi. Paber. Käärid.");
            Start:

            string userChoice;
            int cpuChoice;
            int cpuScore = 0;
            int userScore = 0;
            string newGame;


            Console.WriteLine("\n");
            Console.WriteLine("Võidab mängija, kes saab esimesena kolm punkti.");

            while (cpuScore < 3 && userScore < 3)
            { Console.WriteLine("\n");

            Console.WriteLine("Vali kivi, paber või käärid: ");
            userChoice = Console.ReadLine();

            Random rnd = new Random();
            cpuChoice = rnd.Next(1,4);


                switch (userChoice.ToLower())
                {
                    case "kivi":
                        if (cpuChoice == 1)
                        {
                            Console.WriteLine("Sinu valik: kivi \nArvuti valik: kivi \nVIIK!");
                        }

                        else if (cpuChoice == 2)
                        {
                            Console.WriteLine("Sinu valik: kivi \nArvuti valik: paber \nKAOTASID!");
                            cpuScore++;
                        }

                        else
                        {
                            Console.WriteLine("Sinu valik: kivi \nArvuti valik: käärid \nVÕITSID");
                            userScore++;
                        }
                        break;

                    case "paber":
                        if (cpuChoice == 1)
                        {
                            Console.WriteLine("Sinu valik: paber \nArvuti valik: kivi \nVÕITSID!");
                            userScore++;
                        }

                        else if (cpuChoice == 2)
                        {
                            Console.WriteLine("Sinu valik: paber \nArvuti valik: paber \nVIIK!");
                        }

                        else
                        {
                            Console.WriteLine("Sinu valik: paber \nArvuti valik: käärid \nKAOTASID");
                            cpuScore++;
                        }
                        break;

                    case "käärid":
                        if (cpuChoice == 1)
                        {
                            Console.WriteLine("Sinu valik: käärid \nArvuti valik: kivi \nKAOTASID!");
                            cpuScore++;
                        }

                        else if (cpuChoice == 2)
                        {
                            Console.WriteLine("Sinu valik: käärid \nArvuti valik: paber \nVÕITSID!");
                            userScore++;
                        }

                        else
                        {
                            Console.WriteLine("Sinu valik: käärid \nArvuti valik: käärid \nVIIK");
                        }
                        break;

                    default:
                        break;
                }
            }

            if(userScore < cpuScore)
            {
                Console.WriteLine($"Arvuti punktid: {cpuScore} \nSinu punktid: {userScore} \nKahjuks kaotasid.");
                Uuesti:
                Console.WriteLine("\n");
                Console.WriteLine("Kas soovid veelkord mängida: ");
                newGame = Console.ReadLine().ToLower();

                if (newGame == "jah")
                {
                    goto Start;
                }

                else if (newGame == "ei")
                {
                    Console.WriteLine("Head päeva!");
                }

                else
                {
                    Console.WriteLine("Ei mõista...tegu on eesti keelse programmiga...");
                    goto Uuesti;
                }
                
            }

            else if(userScore > cpuScore)
            {
                Console.WriteLine($"Arvuti punktid: {cpuScore} \nSinu punktid: {userScore} \nPalju õnne, VÕITSID!");
                Uuesti:
                Console.WriteLine("\n");
                Console.WriteLine("Kas soovid veelkord mängida: ");
                newGame = Console.ReadLine().ToLower();

                if (newGame == "jah")
                {
                    goto Start;
                }

                else if (newGame == "ei")
                {
                    Console.WriteLine("Head päeva!");
                }

                else
                {
                    Console.WriteLine("Ei mõista...tegu on eesti keelse programmiga...");
                    goto Uuesti;
                }
            }

            else
            {
                Console.WriteLine($"Arvuti punktid: {cpuScore} \nSinu punktid: {userScore} \nPole võitjaid ega kaotajaid");
                Uuesti:
                Console.WriteLine("\n");
                Console.WriteLine("Kas soovid veelkord mängida: ");
                newGame = Console.ReadLine().ToLower();

                if (newGame == "jah")
                {
                    goto Start;
                }

                else if (newGame == "ei")
                {
                    Console.WriteLine("Head päeva!");
                }

                else
                {
                    Console.WriteLine("Ei mõista...tegu on eesti keelse programmiga...");
                    goto Uuesti;
                }
            }

            Console.ReadLine();


        }
    }
}
