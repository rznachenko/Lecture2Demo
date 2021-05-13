using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    public class Pet
    {
        public Person Owner { get; set; }
        public string PetName { get; }

        public Pet(Person person, string petName)
        {
            Owner = person;
            PetName = petName;
        }

        public override string ToString()
        {
            return $"Pet's owner {Owner} and his nickname is {PetName}";
        }
    }
}
