internal partial class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число,
        // а на выходе показывает третью цифру этого числа
        //      645 -> 5
        //       78 -> третьей цифры нет
        //    32679 -> 6
        Console.WriteLine("Hello, User!");
        string quit, answerOut;
        char quitRepite = 'n';
        do
        {
            Console.WriteLine("Let's display the third character entered");
            Console.Write("Enter number: ");
            answerOut = Console.ReadLine();
            vOutResult(answerOut, strExtractThirdCharacter(answerOut));

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

        string strExtractThirdCharacter(string str)
        {
            string outString;
            if(str.Length < 3){     outString = "третьей цифры нет";}
            else{                   outString = Convert.ToString(str[2]);}
            return outString;
        }

        void vOutResult(string num, string s)
        {
            string outSrting = num + " -> "+ s;
            Console.WriteLine(outSrting);
        }
    }
}
// УРА!
