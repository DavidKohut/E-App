using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenychDK
{
    internal class InsuredPerson
    {

        //Návrh na zlepšení ošetřit vstrup jméná a příjmení, že jméhno i příjmerní budou vždy mít první písmeno velké
        /// <summary>
        /// Name of insured person
        /// </summary>
        public string FirstName {  get; private set; }
        /// <summary>
        /// Surname of insured person
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// Age of insured person
        /// </summary>
        public int Age { get; private set; }    
        /// <summary>
        /// Telefon pojištěného
        /// </summary>
        public int PhoneNumber { get; private set; }
        
        
        
        
        //Návrh na zlepšení telefoní číslo může být zadáno s mezarama nebo bez mezer, zobrazovat se bude vždy všetně mezer, díky čitelnosti
        
        /// <summary>
        /// Konstructor for adding insured person
        /// </summary>
        /// <param name="firstName">First name of insured person</param>
        /// <param name="surname">Surname of insured person</param>
        /// <param name="phoneNumber">Phone number of insured person</param>     
        public InsuredPerson(string firstName,string surname,int age, int phoneNumber)
        {
            FirstName = firstName;
            Surname = surname;
            Age = age;
            PhoneNumber = phoneNumber;

        }

        public override string ToString() 
        { 
            return FirstName + "\t" + Surname + "\t" + Age + "\t" + PhoneNumber ;
        }

    }
}
