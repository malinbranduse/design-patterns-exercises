using System;
namespace Proxy
{
    public class ResponsiblePerson
    {
        private Person person;

        public int Age
        {
            get { return person.Age; }
            set { person.Age = value; }
        }

        public ResponsiblePerson(Person person)
        {
            this.person = person;
        }

        public string Drink()
        {
            return Age >= 18
                ? person.Drink()
                : "too young";
        }

        public string Drive()
        {
            return Age >= 16
                ? person.Drive()
                : "too young";
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
