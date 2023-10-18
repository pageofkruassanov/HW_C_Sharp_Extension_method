using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_Sharp_Extension_method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1:
            int firstEl = 7;
            Console.WriteLine($"Число {firstEl} четное? - {firstEl.ParityCheck()}\n");
            // Task 2:
            int secondEl = 8;
            Console.WriteLine($"Число {secondEl} четное? - {secondEl.ParityCheck()}\n");
            // Task 7:
            Person[] persons = new Person[] { new Person("Pavlo", "Khasanov", 24), new Person("Diana", "Kulinska", 20) };
            persons.PrintAllInfo();
            Console.WriteLine($"Avarage age: {persons.AvarageAge()}\n");
            // Task 8:
            Point3D firstPoint = new Point3D(5, 3, 2);
            Point3D secondPoint = new Point3D(55, 6, 23);
            Console.WriteLine($"Distance: {firstPoint.CalculateDistance(secondPoint)}");

            Console.ReadLine();
        }
    }
}
