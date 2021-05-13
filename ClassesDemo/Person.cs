using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class Person
    {
        private readonly string firstName;
        private readonly Gender gender;
        
        private List<Pet> pets = new List<Pet>();

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName { get; private set; }

        public DateTime Birthday { get; }

        public int Age
        {
            get
            {
                var now = DateTime.Now;

                return now.Year - Birthday.Year;
            }
        }

        public bool HasPets => pets.Count > 0;

        public Person(string firstName, string lastName, DateTime birthday, Gender gender)
        {
            this.firstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            this.gender = gender;
        }

        public void AdoptPet(string petName)
        {
            pets.Add(new Pet(this, petName));
        }

        public override string ToString()
        {
            return $"{ConvertGenderToText()} {FirstName} {LastName} was born in {Birthday.ToString("dd/MMM/yyyy", new CultureInfo("en-GB"))}";
        }

        public string GetPetsName()
        {
            if (HasPets)
            {
                return string.Join(",", pets);
            }
            else
            {
                Console.WriteLine("Has no pets");
                return string.Empty;
            }
        }

        private string ConvertGenderToText()
        {
            return gender == Gender.Male ? "Mister." : "Miss.";
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
