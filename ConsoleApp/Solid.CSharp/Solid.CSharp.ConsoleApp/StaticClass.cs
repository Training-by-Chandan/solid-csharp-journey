namespace Solid.DSharp
{
    public static class StaticClass
    {
        //everything here must be static
        public static int i = 10;

        public static void FunctionOne()
        {
            i++;
            FunctionTwo();
        }

        public static void FunctionTwo()
        {
        }
    }

    public class NonStaticClass
    {
        //may or maynot be static
        public int i = 10;

        public void FunctionOne()
        {
            i++;
            iStatic++;
        }

        public static int iStatic = 10;

        public static void FunctionOneStatic()
        {
            iStatic++;
            //i++; //we cannot access directly
        }
    }
}