using System;
using System.Text;
using Solid.DSharp;

namespace Solid.CSharp.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var res = "n";
            do
            {
                //basic();
                //dataTypes();
                //ControlStatmentsExample();
                //LoopingStatements();
                //StringConcatenation();
                //ClassAndObjects();
                //ClassAndObjectsV2();
                //CustomStackImplementation();
                //PropertiesExample();
                //OperatorOverloadingExample();
                //FunctionCalls();
                //StaticAndNonStaticExplanation();
                //InheritanceExample();
                //InterfaceExample();
                AbstractExample();

                Console.WriteLine("Do you want to run once more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static void AbstractExample()
        {
            int choice = getChoice();
            var shape = AbstractShapeFactory(choice);
            if (shape != null)
            {
                shape.GetInput();
                shape.Area();
                shape.Perimeter();
            }
        }

        private static int getChoice()
        {
            Console.WriteLine("Press\n1 for Square\n2 for Rectangle");
            var choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        private static AShape AbstractShapeFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new ASquare();

                case 2:
                    return new ARectangle();

                default:
                    return null;
            }
        }

        private static void InterfaceExample()
        {
            Console.WriteLine("Press\n1 for Square\n2 for Rectangle\n3 for Circle");
            var choice = Convert.ToInt32(Console.ReadLine());

            var shape = ShapeFactory(choice);
            if (shape != null)
            {
                shape.GetInput();
                shape.Area();
                shape.Perimeter();
            }
        }

        private static IShape ShapeFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Square();

                case 2:
                    return new Rectangle();

                case 3:
                    return new Circle();

                case 4:
                    return new Triangle();

                case 5:
                    return new Pentagon();

                default:
                    return null;
            }
        }

        private static void WithoutInterfaceExample()
        {
            Console.WriteLine("Press\n1 for Square\n2 for Rectangle");
            var choice = Console.ReadLine();
            if (choice == "1")
            {
                Square sq = new Square();
                sq.GetInput();
                sq.Area();
                sq.Perimeter();
            }
            else if (choice == "2")
            {
                Rectangle r = new Rectangle();
                r.GetInput();
                r.Area();
                r.Perimeter();
            }
            else if (choice == "4")
            {
                Triangle t = new Triangle();
                t.GetInput();
                t.Area();
                t.Perimeter();
            }
        }

        private static void InheritanceExample()
        {
            //LivingThings l1 = new LivingThings();
            ////l1.Name = ""; //cannot be accessed
            //var a1 = new Animal();
            //Plant p1 = new Plant();
            //Human h1 = new Human();
            //a1 = new();
            //A a
            //LivingThings l1 = new LivingThings();
            Animal a2 = new Animal("DOG");

            LivingThings l2 = new LivingThings("abc");
            LivingThings a1 = new Animal();
            LivingThings p1 = new Plant();
            LivingThings h1 = new Human();

            l2.Eat();
            a1.Eat();
            p1.Eat();
            h1.Eat();

            Console.WriteLine($"{h1.ToString()}");
            Console.WriteLine($"{l2.ToString()}");
        }

        private static void SingletonExplained()
        {
            Singleton.Instance.CompanyName = "ABC";
        }

        public static void StaticAndNonStaticExplanation()
        {
            //StaticClass sc = new StaticClass();
            StaticClass.i = 10;
            StaticClass.FunctionOne();
            NonStaticClass nsc = new NonStaticClass();
            NonStaticClass nsc1 = new NonStaticClass();
            NonStaticClass nsc2 = new NonStaticClass();
            nsc.FunctionOne();
            nsc1.FunctionOne();
            nsc2.FunctionOne();

            //NonStaticClass.iStatic = 10;
            //nsc.i = 20;
        }

        private static void FunctionCalls()
        {
            int y = StaticClass.i;
            StaticClass.i = 20;
            FunctionClass fc = new FunctionClass();
            fc.FuncTwo(1, "abc", 10f);
            fc.FuncTwo(b: "abc", a: 1);
            fc.FuncTwo(10, f: 20f);
            fc.FuncTwo();
            int a = 16;
            int b = 17;
            int res = 5;
            fc.AddV3(a, b, ref res);
            fc.AddV4(a, b, out res);
            var data = fc.FuncThree();
        }

        private static void OperatorOverloadingExample()
        {
            StudentInfo firstTerm = new StudentInfo(0, 80, 28);
            firstTerm.Math = 10;
            firstTerm.Science = 20;
            StudentInfo secondTerm = new StudentInfo(0, 80, 28);
            secondTerm.Math = 10;
            secondTerm.Science = 20;
            StudentInfo finalTerm = new StudentInfo(0, 80, 28);
            finalTerm.Math = 101;
            finalTerm.Science = -1;

            //var totalMin = firstTerm.Min + secondTerm.Min + finalTerm.Min;
            //var totalMax = firstTerm.Max + secondTerm.Max + finalTerm.Max;
            //var totalPass = firstTerm.Pass + secondTerm.Pass + finalTerm.Pass;
            //StudentInfo total = new StudentInfo(totalMin, totalMax, totalPass);
            //total.Math = firstTerm.Math + secondTerm.Math + finalTerm.Math;
            //total.Science = firstTerm.Science + secondTerm.Science + finalTerm.Science;
            //total.English = firstTerm.English + secondTerm.English + finalTerm.English;
            int i = (10 + 20) * (30 + 40);
            StudentInfo final = firstTerm + secondTerm + finalTerm - firstTerm + secondTerm;
            //i++;
            //firstTerm++;
            //firstTerm = firstTerm + 5;

            var eq = firstTerm == secondTerm;
        }

        private static void PropertiesExample()
        {
            StudentInfo si = new StudentInfo(0, 80, 28);
            si.Math = 101;
            si.Science = -1;

            Console.WriteLine($"Total = {si.Total}");
            Console.WriteLine($"Percentage = {si.Percentage}");
            Console.WriteLine($"Division = {si.Division}");
            Console.WriteLine("=======================");
            Console.WriteLine("After Changing the marks");
            si.Math = 80;
            si.Science = 73;
            Console.WriteLine($"Total = {si.Total}");
            Console.WriteLine($"Percentage = {si.Percentage}");
            Console.WriteLine($"Division = {si.Division}");
            Console.WriteLine("=======================");
        }

        private static void CustomStackImplementation()
        {
            CustomStack cs = new CustomStack();
            cs.Push(1);
            cs.Push(2);
            cs.Push(3);
            cs.Pop();
            cs.Push(4);
            cs.Push(5);
            cs.Push(6);
            cs.Push(7);
            cs.Push(8);
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
        }

        private static void ClassAndObjectsV2()
        {
            try
            {
                // StudentInfo nabin = new StudentInfo("Nabin");
                StudentInfo student = new StudentInfo();
                Console.WriteLine("Enter the name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Math");
                student.Math = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Info is \nName : {student.Name}\nAge : {student.Age}\nMath : {student.Math}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ClassAndObjects()
        {
            HumanBeing nabin = new HumanBeing();
            HumanBeing bhim = new HumanBeing();
            nabin = new HumanBeing();
            nabin.age = 10;
            var i = 10;
            bhim = new HumanBeing(i);
            bhim.age = 12;
            Console.WriteLine(bhim.age);
        }

        private static void StringConcatenation()
        {
            string a = "Hello";
            string b = "World";
            string res1 = a + " " + b; //concatenation

            //formatting
            string template = "{0} {1}";
            var res2 = string.Format(template, a, b);

            //string interpolation
            var res3 = $"{a} {b}, => {a} and {b}";

            //string builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dear Sir,");
            sb.AppendLine("\tLorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            sb.AppendLine("Lorem ipsum dolor sit amet consectetur adipisicing elit. Eaque odit id totam consectetur hic velit minima veritatis doloremque magnam! Quia dolor quis eum, ut dicta perspiciatis sapiente illum laborum aliquid.");
            var result = sb.ToString();
            Console.WriteLine(result);
        }

        private static void LoopingExamplesV2()
        {
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < days.Length - 1; i++)
            {
                Console.WriteLine("The day is {0}", days[i]);
            }

            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
        }

        private static void LoopingStatements()
        {
            //known quantity and unknown quantity
            //for, foreach, while, do while
            Console.WriteLine("Enter the number");
            var num = Convert.ToInt32(Console.ReadLine());

            {
                Console.WriteLine("===========================");
                Console.WriteLine("using do while");
                int i = 1;
                do
                {
                    if (i == 5)
                    {
                        i++;
                        continue;
                    }
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                    i++;
                } while (i <= 10);
            }

            {
                Console.WriteLine("===========================");
                Console.WriteLine("using while");
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                    i++;
                }
            }

            {
                Console.WriteLine("===========================");
                Console.WriteLine("using for loop");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + num * i);
                }
            }
        }

        private static void ControlStatmentsExample()
        {
            Console.WriteLine("Enter the number of day");
            var num = Convert.ToInt32(Console.ReadLine());

            ifElseStatement(num);

            switchCaseStatement(num);
            //(condition) ? <true statement> : <false statement>
        }

        private static void ifElseStatement(int num)
        {
            if (num == 1) Console.WriteLine("Sunday");
            else if (num == 2) Console.WriteLine("Monday");
            else if (num == 3) Console.WriteLine("Tuesday");
            else if (num == 4) Console.WriteLine("Wednesday");
            else if (num == 5) Console.WriteLine("Thursday");
            else if (num == 6) Console.WriteLine("Friday");
            else if (num == 7) Console.WriteLine("Saturday");
            else Console.WriteLine("Not a Valid Day");
        }

        private static void switchCaseStatement(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Not a Valid Day");
                    break;
            }
        }

        private static void dataTypes()
        {
            int e = 10; //32 bit signed integer number
            short s = 10; //16 bit int number
            e = 65546;
            s = (short)e;
            Console.WriteLine("Int value = " + e);
            Console.WriteLine("short value = " + s);

            //char > int > long > float > double
            //implicit casting
            char c = 'C';
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            //explicit casting
            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;
            c = (char)d;

            //string str = i.ToString();
            //int x = (int)str;
        }

        private static void basic()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Name = " + name);
        }
    }
}