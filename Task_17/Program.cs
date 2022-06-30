// 17.
// Напишите программу, которая принимает на вход координаты точки
// (X, Y), причем X!=0, Y!=0, и выдаёт номер четверти, в которой 
// находится эта точка

internal class Program
{
    private static void Main(string[] args)
    {
        string strQuorter;
        Console.WriteLine("Enter point coordinates (X, Y)");
        Console.Write("X: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        strQuorter = Quarter (x, y);
        Console.WriteLine(strQuorter);
        Console.WriteLine(Quarter (9, 1));

        // if      (x > 0 && y > 0) Console.WriteLine("First  quarter");
        // else if (x < 0 && y > 0) Console.WriteLine("Second quarter");
        // else if (x < 0 && y < 0) Console.WriteLine("Third  quarter");
        // else if (x < 0 && y > 0) Console.WriteLine("Fourth quarter");
        // else                     Console.WriteLine("Coordinates had entered incorrect");

        string Quarter (int x, int y){
            string strReturn;
            if      (x > 0 && y > 0) strReturn = "First  quarter";
            else if (x < 0 && y > 0) strReturn = "Second quarter";
            else if (x < 0 && y < 0) strReturn = "Third  quarter";
            else if (x < 0 && y > 0) strReturn = "Fourth quarter";
            else                     strReturn = "Coordinates had entered incorrect";
            return strReturn;
        }


    }
}
