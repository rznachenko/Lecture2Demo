using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Alice", "Johnson", new DateTime(1990, 2, 6), Gender.Female);
            Console.WriteLine(person.ToString());
            Console.WriteLine("An now she is " + person.Age + " years old");
            person.AdoptPet("Baron");
            person.AdoptPet("Murchik");
            Console.WriteLine(person.ToString() + " Does she have pets : " + (person.HasPets ? "Yes" : "No"));
            Console.WriteLine(person.GetPetsName());
        }

        public static void ExceptionExample()
        {
            try
            {

            }
            catch (Exception)
            {

            }
            
        }
    }
}
