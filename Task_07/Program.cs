// See https://aka.ms/new-console-template for more information
/**************************************************************
*   Задача: Напишите программу, которая на вход принимает трёх-
*   значное число (по условию и под ответственность пользователя),
*   и выводит обратно младший разряд (в десятичном формате счисления)
***************************************************************/
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
string quit;
char quitRepite = 'n';
int a; int b;
do{
    Console.Write("Enter a three-digit number: ");
    a = Convert.ToInt32(Console.ReadLine());
    b = a % 10;
    Console.WriteLine($"The least significant digit of the entered number is {b}");

    Console.WriteLine("Would you like to continue? If yes, then click 'Y'");
    quit = Console.ReadLine();
    quit = quit.ToLower();
    if('y' == Convert.ToChar(quit[0])){
        Console.WriteLine("What will we continue");
        
    }
    else{
        quitRepite = 'y';
    };

}while(quitRepite == 'n');
 Console.WriteLine("We will be glad to see you again!");
 Console.Beep(); Console.Beep();    // УРА!
