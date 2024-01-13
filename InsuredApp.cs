using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenychDK
{
    class InsuredApp
    {
        private Database database;
        private InsuredPerson insuredPerson;
       
        /// <summary>
        /// New instance of database
        /// </summary>
        public InsuredApp()
        { 
            database = new Database();

        }

           
        /// <summary>
        /// Writes main menu
        /// </summary>
        public void WriteMainMenu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------------------------------------------------------\n");

            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
            Console.WriteLine("\n\n");
            Console.Write("Volba: ");
        }
        /// <summary>
        /// Adds person
        /// </summary>
        public void AddPerson()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine( " Přidání nového pojištěného ");
            Console.WriteLine("------------------------------\n");
            //Name input
            string firstName = "";
            Console.WriteLine("\nZadej jméno pojištěného:");
            firstName = Console.ReadLine();
            while (firstName.Length < 2)
            {
                Console.WriteLine("Křestní jméno musí mít alespoň 2 písmena, zadej znovu křestní jméno:");
                firstName = Console.ReadLine();
            }
            
            //Surname input
            string surname = "";
            Console.WriteLine("\nZadej příjmenmí pojištěného ");
            surname = Console.ReadLine();
            while (surname.Length < 2)
            {
                Console.WriteLine("Příjmení musí mít alespoň 2 písmena, zadej znovu příjmení:");
                surname = Console.ReadLine();
            }

            //Age input
            int age = 0;
            Console.WriteLine("\nZadej věk pojištěného:");
            while (!(int.TryParse(Console.ReadLine(), out age)))
            {
                Console.WriteLine("Zadal jsi neplatný věk, prosím zadej věk znovu:");
            }

            //Phone number input
            Console.WriteLine("\nZadej telefonní číslo pojištěného:");

            string phoneInput = Console.ReadLine().Trim();

            int phoneNumber;

            while (!(int.TryParse(phoneInput, out phoneNumber)))
            {
                Console.WriteLine("Zadal jsi telefonní číslo ve špatném formátu, zadej číslo znovu:");
                phoneInput= Console.ReadLine().Trim();
            }

            //Write to database
            database.AddPersonRecord(firstName, surname, age, phoneNumber);

            //Text notification that confirms adding new person
            Console.WriteLine($"\nData byla uložena, byl založen nový uživatel: {firstName} {surname}\n");
             

        }
        /// <summary>
        /// Commands database to display all insured persons
        /// </summary>
        public void DisplayListOfInsured()
        {   Console.Clear();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Zobrazení seznamu pojištěných");
            Console.WriteLine("------------------------------\n\n");

            database.ListOfInsuredRecords();

        }

        /// <summary>
        /// Searchs for specific person by name and surname
        /// </summary>
        public void SearchPerson()
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Vyhledání pojištěného");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("Zadej křestní jméno osoby, kterou chceš vyhledat:");
            string firstNameSearch=Console.ReadLine();
            Console.WriteLine("Zadej příjmení osoby, kterou chceš vyhledat:");
            string surnameSearch=Console.ReadLine();
            database.SearchPersonRecord(firstNameSearch, surnameSearch);
            
        }

        /// <summary>
        /// End of form
        /// </summary>
        public void PresKeyForReturnToMenu()
        {
            Console.WriteLine("\n--------------------------------------------------------------------");
            Console.WriteLine("Stiskni libovolnou klávesu pro návrat do hlavního menu.");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ReadKey();

        }

    }
}
