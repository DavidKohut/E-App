namespace EvidencePojistenychDK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsuredApp insuredApp = new InsuredApp();
            Console.WriteLine("Vádej v programu pro evidenci pojištěných osob.");
            Console.WriteLine("Pokračuj stiskem libovolné klávesy:");
            Console.ReadKey();

            int menuChoice = 0;

            //Main cycle of app
            while (menuChoice != 4)
            {
                //Draw on main menu
                insuredApp.WriteMainMenu();

                //Menu choice inputcheck
                while (!(int.TryParse(Console.ReadLine(), out menuChoice)))
                {
                    Console.WriteLine("Neplatná volba, vyber akci znovu:\n");
                    menuChoice = int.Parse(Console.ReadLine());
                }

                //Switch with different cases by choices from menu
                switch (menuChoice)
                {
                    //Adds new person to database
                    case 1:
                        {
                            
                            insuredApp.AddPerson();
                            insuredApp.PresKeyForReturnToMenu();

                        }
                        break;

                    //Displays all persons from database
                    case 2:
                        {
                            
                            insuredApp.DisplayListOfInsured();
                            insuredApp.PresKeyForReturnToMenu();
                        }
                        break;


                    //Searches for specific person from database
                    case 3:
                        {
                            
                            insuredApp.SearchPerson();
                            insuredApp.PresKeyForReturnToMenu();
                        }
                        break;

                    //End of program
                    case 4:
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("--------------------------------------------------------------------\n");
                            Console.WriteLine("Program se ukončí.");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.WriteLine("Prosím zadej číslo od 1 do 4");
                        break;

                }








            }
        }
    }
}
