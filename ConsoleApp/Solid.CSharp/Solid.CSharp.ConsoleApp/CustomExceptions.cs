namespace Solid.CSharp.ConsoleApp
{
    [Serializable]
    public class TestException : Exception
    {
        public TestException()
        { }

        public TestException(string message) : base(message)
        {
        }

        public TestException(string message, Exception inner) : base(message, inner)
        {
        }

        public void WriteInFile()
        {
            //code to write the exceptions in file
        }
    }

    [Serializable]
    public class NUmber10Exception : Exception
    {
        public NUmber10Exception()
        {
            //WriteInFile();
        }

        public NUmber10Exception(string message) : base(message)
        {
           // WriteInFile();
        }

        public NUmber10Exception(string message, Exception inner) : base(message, inner)
        {
            //WriteInFile();
        }

        public void WriteInFile()
        {
            //code to write the exceptions in file
        }
    }
}