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
    }

    public class Plant : LivingThings
    {
        public Plant() : base("Default")
        {
        }
    }

    public class Vertibrates : Animal
    {
        public Vertibrates() : base()
        {
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
    }
}