internal partial class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход трёхзначное число
        // и проверяет, а на выходе показывает вторую цифру этого числа
        //      456 -> 5
        //      782 -> 8
        //      918 -> 1
        Console.WriteLine("Hello, User!");
        string quit, answerOut;
        char quitRepite = 'n';
        int first;
        do
        {
            Console.WriteLine("Let's enter a three-digit number, and display only the second character of this number");
            Console.Write("Enter number: ");
            answerOut = Console.ReadLine();
            first = Convert.ToInt32(answerOut);
            vOutResult(i32ExtractSecondCharacter(first), answerOut);

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

        int i32ExtractSecondCharacter(int chkNum)
        {
            int iReturn = chkNum % 100;
            return iReturn / 10;
        }

        void vOutResult(int b, string s)
        {
            s = s + " -> " + Convert.ToString(b);
            Console.WriteLine(s);
        }
    }
}
// УРА!
