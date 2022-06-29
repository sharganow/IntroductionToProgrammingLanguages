internal partial class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход цифру,
        // обозначающую день недели, и проверяет, является ли этот 
        // день выходным
        //      6 -> да
        //      7 -> да
        //      1 -> нет
        Console.WriteLine("Hello, User!");
        string quit, answerOut;
        int i32Week;
        char quitRepite = 'n';
        do
        {
            Console.WriteLine("Let's find out when the day off");
            Console.Write("Enter number: ");
            answerOut = Console.ReadLine();
            i32Week = Convert.ToInt32(answerOut);
            vOutResult(i32Week, strDayOff(i32Week));

            Console.WriteLine("Would you like to continue? If yes, then click 'Y'");
            quit = Console.ReadLine();
            quit = quit.ToLower();
            if ('y' == Convert.ToChar(quit[0]))
            {
                Console.WriteLine("What will we continue");

            }
            else
            {
                quitRepite = 'y';
            };

        } while (quitRepite == 'n');
        Console.WriteLine("We will be glad to see you again!");

        string strDayOff(int day)
        {
            string outString;
            switch(day){
                case 0:{
                    outString = "нет такого дня";
                }break;
                case 1: case 2: case 3: case 4: case 5:{
                    outString = "нет, сегодня работаем";
                }break;
                case 6: case 7:{
                    outString = "да, сегодня отдыхаем";
                }break;
                default:{
                    int dev = day%7;
                    if(dev == 0){
                        dev = day / 7;
                        dev = day - ((dev - 1)*7);
                        outString = strDayOff((dev)) + " , но это " + Convert.ToString((day / 7)) + "-ая неделя";                     
                    }
                    else{
                        outString = strDayOff((dev)) + " , но это " + Convert.ToString((day / 7) + 1) + "-ая неделя";
                    }      
                }break;
            }
            return outString;
        }

        void vOutResult(int num, string s)
        {
            string outSrting = Convert.ToString(num) + " -> "+ s;
            Console.WriteLine(outSrting);
        }
    }
}
// УРА!
