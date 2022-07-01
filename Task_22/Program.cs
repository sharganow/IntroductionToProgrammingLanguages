// Задача №22
// Напишите программу, которая проинимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N
//      5 -> 1, 4, 9, 16, 25
//      2 -> 1, 4

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
                QuarterRange += Convert.ToString(Math.Pow(i++, 2)) + " ";
            }
            return QuarterRange;
        }
    }
}