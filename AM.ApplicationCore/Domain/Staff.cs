﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff :Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return this.EmployementDate + " " + this.Function + " " + this.Salary;
        }

        public override void PassengerType()
        {
            base.PassengerType(); //faire appel la méthode de la classe mére 

            Console.WriteLine("I'm a Staff Member");
        }


    }
}
