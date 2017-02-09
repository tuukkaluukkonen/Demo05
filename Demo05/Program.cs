using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henkilorekisteri
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a few person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Mainio",
                SocialSecurityNumber = "280410-1870"
            };

            Person person2 = new Person
            {
                Firstname = "Tepi",
                Lastname = "Turha",
                SocialSecurityNumber = "123454-0405"
            };

            Person person3 = new Person
            {
                Firstname = "Rami",
                Lastname = "Aasikka",
                SocialSecurityNumber = "098535-3345"

            };

            // create a Persons object
            Persons myFriends  = new Persons();

            // add person objects to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // Get one person from persons collection
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());

            } else
            {
            
                Console.WriteLine("Person nt found in that index!");
            }

            // Print collection
            myFriends.PrintCollection();

            // find person
            string sotu = "123454 - 0405";
            Console.WriteLine("Find sotu :" + sotu);
            Person person5 = myFriends.FindPerson(sotu));
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Cant find person with that sotu...");
            }
        }
    }
}
