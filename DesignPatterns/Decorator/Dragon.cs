using System;
namespace Decorator
{
    public class Dragon
    {
        private Bird bird;
        private Lizard lizard;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; bird.Age = value; lizard.Age = value; }
        }

        public Dragon()
        {
            bird = new Bird();
            lizard = new Lizard();
        }

        public string Fly()
        {
            return bird.Fly();
        }

        public string Crawl()
        {
            return lizard.Crawl();
        }
    }
}
