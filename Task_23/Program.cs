// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

//          3 -> 1, 8, 27
//          5 -> 1, 8, 27, 64, 125
internal class Program
{
    private static void Main(string[] args)
    {
        string strQuarterRange;
        Console.Write("Enter number N:");
        int intN = Convert.ToInt32(Console.ReadLine());
        strQuarterRange = MakeQuarterRange(intN);
        Console.WriteLine(strQuarterRange);

        string MakeQuarterRange(int number)
        {
            string QuarterRange = Convert.ToString(number) + " -> ";
            int i = 1;
            while (i <= number)
            {
                QuarterRange += Convert.ToString(Math.Pow(i++, 3)) + " ";
            }
            return QuarterRange;
        }
    }
}
