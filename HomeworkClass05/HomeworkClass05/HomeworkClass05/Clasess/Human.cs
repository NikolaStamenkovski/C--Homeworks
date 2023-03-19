using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass05.Clasess
{
    public class Human
    {
        public Human() 
        { 
        }
        public Human(string firstName, string lastName, string age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

      

        public string GetPersonStats()
        {
            return $"Fullname: {FirstName} {LastName}, Age: {Age}";
        }
    }
}
