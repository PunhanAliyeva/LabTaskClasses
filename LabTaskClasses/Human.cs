using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskClasses
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string City;

        public Human(string name,string surname,byte age,string city)
        {
            Name = name;
            Surname = surname;
            Age = age;
            City = city;
        }
        public bool IsStudent()
        {
            if (Age > 18 && Age < 25)
            {
                return true;
            }
            return false;
        }
        public Human()
        {
            
        }
        public void CheckCity(string city1, string city2, string city3, string city4)
        {
            if (city1.Equals(city3))
            {
                Console.WriteLine("Eyni seherdedir..");
            }
            if (city2.Equals(city4))
            {
                Console.WriteLine("Eyni seherdedir..");
            }
            else
            {
                Console.WriteLine("Eyni seherde deyil..");
            }
        }

    }
}
