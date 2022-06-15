namespace Solid.DSharp
{
    //threads
    //tasks
    //async await
    public class ParallelProgramming
    {
        public async void Run()
        {
            //FunctionOne();
            //FunctionTwo();

            //Thread t1 = new Thread(FunctionOne);
            //Thread t2 = new Thread(FunctionTwo);
            //t1.Start();
            //t2.Start();

            //TaskOne();
            //TaskTwo();

            //Task<int> t1 = new Task<int>(TaskOne);
            //Task<string> t2 = new Task<string>(TaskTwo);
            //t1.Start();
            //t2.Start();
            //var val1 = t1.Result;
            //var val2 = t2.Result;

            //Task.Run(() =>
            //{
            //    TaskOne();
            //});

            //Task.Factory.StartNew(() =>
            //{
            //    TaskTwo();
            //});

            var res = TaskThree();
            var res1 = TaskFour();
            Console.WriteLine(res);
            Console.WriteLine(res1.Result);

            // Console.WriteLine($"Task One {val1}");

            //Task
        }

        public void FunctionOne()
        {
            Thread.Sleep(100);
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Function One Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
            }
        }

        public void FunctionTwo()
        {
            Thread.Sleep(150);
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function Two Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1250);
            }
        }

        public int TaskOne()
        {
            Thread.Sleep(100);
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Task One Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
            }
            return 1;
        }

        public string TaskTwo()
        {
            Thread.Sleep(150);
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Task Two Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1750);
            }
            return "Task 2 ended";
        }

        public async Task<int> TaskThree()
        {
            await Task.Delay(100);
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Task Three Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                await Task.Delay(1000);
            }
            return 1;
        }

        public async Task<string> TaskFour()
        {
            await Task.Delay(150);
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Task Four Says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
                await Task.Delay(1750);
            }
            return "Task 2 ended";
        }
    }
}