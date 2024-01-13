using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenychDK
{
    public class Database
    {
        /// <summary>
        /// List of records
        /// </summary>
        private List<InsuredPerson> listOfInsured;

        /// <summary>
        /// Creates new instance database
        /// </summary>
        public Database()
        {
            listOfInsured = new List<InsuredPerson>();
        }

        /// <summary>
        /// Add new person to list of insured
        /// </summary>
        public void AddPersonRecord(string firstName, string surname, int age, int phoneNumber)
        {

            listOfInsured.Add(new InsuredPerson(firstName, surname, age, phoneNumber));
        }

        
        /// <summary>
        /// Returns list of insured persons
        /// </summary>
        public void ListOfInsuredRecords()
        {
            
            
            foreach (InsuredPerson insuredPerson in listOfInsured) 
            {

                Console.WriteLine(insuredPerson);
            }
            
        }


        /// <summary>
        /// Searchs for insured person
        /// </summary>
        /// <param name="firstName">First name of person you want to find</param>
        /// <param name="surname">Last name of person you want to find</param>
        public void SearchPersonRecord(string firstName, string surname)
        {
            List<InsuredPerson> searchRecordsFound = new List<InsuredPerson>();
            foreach (InsuredPerson person in listOfInsured)
            {
                if ((person.FirstName.ToLower() == firstName.ToLower()) && (person.Surname.ToLower() == surname.ToLower()))
                    searchRecordsFound.Add(person);
            }

            foreach (InsuredPerson searchedPerson in searchRecordsFound)
            {
                Console.WriteLine(searchedPerson);
            }

            if (searchRecordsFound.Count == 0)
            {
                Console.WriteLine("\n\nNebyly nalezeny žádné výsledky dle zadaných parametrů.");
            }
            

        }
        

    }
}
