namespace Solid.DSharp
{
    public class LivingThings
    {
        protected string Name;

        public LivingThings()
        {
            Name = "Default";
        }

        public LivingThings(string name)
        {
            Name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Living things can eat");
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base()
        {
            Name = "Animal";
        }

        public Animal(string name) : base()
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine("Animal can eat");
        }
    }

    public class Plant : LivingThings
    {
        public Plant() : base("Default")
        {
        }

        public void Eat()
        {
            Console.WriteLine("Plant can eat");
        }
    }

    public class Vertibrates : Animal
    {
        public Vertibrates() : base()
        {
        }

        public virtual void Eats()
        {
            Console.WriteLine("Vertibrates Can Eat");
        }
    }

    public class Invertibrates : Animal
    {
        public Invertibrates()
        {
        }
    }

    public class Human : Vertibrates
    {
        public Human()
        {
        }

        public override void Eats()
        {
            Console.WriteLine("Human Can Eat");
        }

        public override string ToString()
        {
            return "Hi I am from human object";
        }
    }
}