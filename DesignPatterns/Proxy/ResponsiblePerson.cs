using System;
namespace Proxy
{
    public class ResponsiblePerson
    {
        private Person person;

        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public string Drink()
        {
            return person.Age >= 18
                ? person.Drink()
                : "too young";
        }

        public string Drive()
        {
            return person.Age >= 16
                ? person.Drive()
                : "too young";
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
