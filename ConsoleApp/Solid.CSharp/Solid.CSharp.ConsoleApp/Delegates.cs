namespace Solid.DSharp
{
    public class Delegates
    {
        public delegate void MathOps(int a, int b);

        public delegate int TestDG(int a);

        public event MathOps MathHandler;

        public void Run(int a, int b)
        {
            MathHandler?.Invoke(a, b);
        }

        public void Run()
        {
            // TestDG t = FunctionOne;
            // Unicast();
            MultiCast();
        }

        private void MultiCast()
        {
            MathOps m = Add;
            m(10, 6);
            Console.WriteLine("Adding Subtract method");
            m += Subtract;
            m(10, 6);
            Console.WriteLine("After adding multiply function");
            m += Multiple;
            m(10, 6);
            Console.WriteLine("After adding divide function");
            m += Divide;
            m(10, 6);

            m -= Add;
            m(10, 6);
        }

        public int FunctionOne(char a)
        {
            return 0;
        }

        private void Unicast()
        {
            //single function pointer
            MathOps m;
            Console.WriteLine("Enter the choice");
            var choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 2:
                    m = Subtract;
                    break;

                case 3:
                    m = Multiple;
                    break;

                case 4:
                    m = Divide;
                    break;

                default:
                    m = Add;
                    break;
            }
            m(10, 6);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine($"Differnce = {x - y}");
        }

        public void Multiple(int x, int y)
        {
            Console.WriteLine($"Product = {x * y}");
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine($"Quotient = {x / y}");
        }
    }
}