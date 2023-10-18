using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Extension_method
{
    public static class PersonExtensions
    {
        public static double AvarageAge(this Person[] persons)
        {
            if(persons.Length == 0)
            {
                new Exception("Error / Age");
            }

            int minAge = persons[0].Age;
            int maxAge = persons[0].Age;

            foreach (var person in persons)
            {
                if(person.Age < minAge)
                {
                    minAge = person.Age;
                }
            }

            foreach (var person in persons)
            {
                if(person.Age > maxAge)
                {
                    maxAge = person.Age;
                }
            }

            return (double)(minAge + maxAge) / 2;
        }

        public static void PrintAllInfo(this Person[] persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}. Surname: {person.Surname}. Age: {person.Age}");
            }
        }
    }
}
