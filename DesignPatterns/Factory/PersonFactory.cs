using System;
namespace Factory
{
    public class PersonFactory
    {
        private int IdCounter = 0;

        public Person CreatePerson(string name)
        {
            return new Person { Id = IdCounter++, Name = name };
        }
    }
}
