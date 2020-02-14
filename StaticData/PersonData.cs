using System;
using System.Collections.Generic;
using System.Linq;
using Website.Models;

namespace Website.StaticData
{
    public class PersonData
    {
        public static List<Person> People 
        {
            get
            {
                return listOfPeople;
            }
        }

        private static List<Person> listOfPeople = new List<Person>()
        {
            new Person() { Name = "Gery", Department = "ATC", Years = 4.9M },
            new Person() { Name = "Lucky", Department = "ATC", Years = 2.2M },
            new Person() { Name = "Mike", Department = "ATC", Years = 5.5M },
            new Person() { Name = "R2-D2", Department = "Nedbank", Years = 123.45M },
            new Person() { Name = "BB-8", Department = "Absa", Years = 555.55M },
            new Person() { Name = "C1-10P", Department = "Standard Bank", Years = 99 },
        };
    }
}