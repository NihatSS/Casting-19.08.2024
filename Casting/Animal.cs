using System.Threading.Channels;

namespace Casting
{
    abstract class Animal
    {
        public abstract void Eat();
    }


    abstract class Fish : Animal, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Swim as fish");
        }
    }

    class Shark : Fish
    {
        public void SayMeyxana()
        {
            Console.WriteLine("blah blah blah");
        }

       public override void Eat()
        {
            Console.WriteLine("Shark eating little fish");
        }
    }

    abstract class Pet : Animal
    {
        public void Feed()
        {
            Console.WriteLine("Feed as pet");
        }
    }

    class Cat : Pet
    {
        public void TakeCare()
        {
            Console.WriteLine("Take care of cat");
        }

        public override void Eat()
        {
            Console.WriteLine("Cat eating whiskas"); ;
        }
    }

    abstract class Bird :Animal, IFly
    {
        public virtual void Fly()
        {
            Console.WriteLine("Fly as bird");
        }
    }

    class Duck : Bird, ISwim
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }

        public override void Eat()
        {
            Console.WriteLine("Duck eating everything");
        }
        public override void Fly()
        {
            Console.WriteLine("Duck cannot fly");
        }

        public void Swim()
        {
            Console.WriteLine("Swim as duck");
        }
    }

    class Parrot : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Parrot eat wheat");
        }

        public void Talk()
        {
            Console.WriteLine("Saaalaaams");
        }
    }

    class Owl : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Owl eating bread") ;
        }
    }
}
