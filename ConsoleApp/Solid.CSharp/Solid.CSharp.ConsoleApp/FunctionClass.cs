namespace Solid.DSharp
{
    public class FunctionClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int x, int y, int z) => x + y + z;

        public int AddV2(int a, int b) => a + b;

        public void FuncOne(int x, string y)
        {
        }

        public void FuncOne(string y, int x)
        {
        }

        public void FuncTwo(int a = 10, string b = "Default", float f = 10f)
        {
        }

        public void AddV3(int a, int b, ref int result)
        {
            // result = a + b;
        }

        public void AddV4(int a, int b, out int result)
        {
            a++;
            b++;
            result = a + b;
        }

        public void AddV4(in int a, in int b, out int result)
        {
            //a++;
            //b++;
            result = a + b;
        }

        public (bool, string, int) FuncThree()
        {
            return (true, "Added Successfully", 10);
        }
        public TestModel FuncFour()
        {
            return new TestModel() { Id=1, Age=20, Name="Tirtha", Status=true };
        }
    }

    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public float Age { get; set; }
    }
}