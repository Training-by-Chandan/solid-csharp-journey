namespace Solid.DSharp
{
    public class Test
    {
        private static void OperatorOverloadingExample()
        {
            StudentInfo firstTerm = new StudentInfo(0, 80, 28);
            firstTerm.Math = 101;
            firstTerm.Science = -1;
            StudentInfo secondTerm = new StudentInfo(0, 80, 28);
            secondTerm.Math = 101;
            secondTerm.Science = -1;
            StudentInfo finalTerm = new StudentInfo(0, 80, 28);
            finalTerm.Math = 101;
            finalTerm.Science = -1;

            var totalMin = firstTerm.Min + secondTerm.Min + finalTerm.Min;
            var totalMax = firstTerm.Max + secondTerm.Max + finalTerm.Max;
            var totalPass = firstTerm.Pass + secondTerm.Pass + finalTerm.Pass;
            StudentInfo total = new StudentInfo(totalMin, totalMax, totalPass);
            total.Math = firstTerm.Math + secondTerm.Math + finalTerm.Math;
            total.Science = firstTerm.Science + secondTerm.Science + finalTerm.Science;
            total.Science = firstTerm.Science + secondTerm.Science + finalTerm.Science;
        }
    }
}