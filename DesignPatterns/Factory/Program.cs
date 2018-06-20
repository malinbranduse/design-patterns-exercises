using System;

namespace Factory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var personFactory = new PersonFactory();
            var malin = personFactory.CreatePerson("Malin");
            var steve = personFactory.CreatePerson("Steve");
            Console.WriteLine(malin);
            Console.WriteLine(steve);
        }
    }
}
