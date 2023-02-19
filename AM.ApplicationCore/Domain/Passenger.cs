using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PasseportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> flights { get; set; }
        public bool CheckProfile(string first_Name, string last_Name, string v)
        {

            return first_Name == FirstName && last_Name == LastName;

        }
        public bool CheckProfile1(string first_Name, string last_Name, string mail)
        {

            return first_Name == FirstName && last_Name == LastName && mail == EmailAdress;

        }
        //paramétre optionelle
        //public bool CheckProfile(string first_Name, string last_Name, string mail=null) {
        //    if (mail != null)
            
        //        return first_Name == FirstName && last_Name == LastName && mail==EmailAdress;

        //    }
        //    else
        //    {
        //        return first_Name == FirstName && last_Name == LastName;
        //    }
        //}
        public virtual void PassengerType()
        {

            Console.WriteLine("I'm a Passenger");
        }



    }

    
}
