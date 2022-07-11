using Solid.DSharp;

namespace Solid.CSharp.ConsoleApp
{
    public class Templates<T1, T2, T3>
        where T1 : struct
        where T2 : class
        where T3 : IShape, IInterfaces
    {
        public T1 Item1 { get; set; }
        public T1 Item2 { get; set; }
        public T2 Item3 { get; set; }
        public T2 Item4 { get; set; }
        public T3 Item5 { get; set; }
        public T3 Item6 { get; set; }
    }

    public class TemplatesV2
    {
        public string Item1 { get; set; }
        public string Item2 { get; set; }

        public static void FunctionOne<T1, T2>(T1 item1, T1 item2, T2 item3, T2 item4)
            where T1 : IShape
            where T2 : class
        {
        }
    }
}