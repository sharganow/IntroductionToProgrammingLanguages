// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (X и Y).
internal class Program
{
    private static void Main(string[] args)
    {
        string strCoordinateRange;
        Console.Write("Enter number of quarter:");
        int intQuarter = Convert.ToInt32(Console.ReadLine());
        strCoordinateRange = CoordinateRange (intQuarter);
        Console.WriteLine(strCoordinateRange);
        Console.WriteLine(CoordinateRange (2));


        string CoordinateRange (int xQuarter){
            string strReturn;
            switch(xQuarter){
                case 1:{
                    strReturn = "X > 0, Y > 0";
                }break;
                case 2:{
                    strReturn = "X < 0, Y > 0";
                }break;
                case 3:{
                    strReturn = "X < 0, Y < 0";
                }break;
                case 4:{
                    strReturn = "X > 0, Y < 0";
                }break;
                default:{
                    strReturn = "Coordinates had entered incorrect";
                }break;
            }
            return strReturn;
        }
    }
}

