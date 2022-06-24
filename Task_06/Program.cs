// See https://aka.ms/new-console-template for more information
/**************************************************************
*   Задача: Напишите программу, которая на вход принимает число 
*   и выдаёт, является ли число чётным 
*   (делится ли оно на два без остатка).
***************************************************************/
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
string quit;
char quitRepite = 'n';
int a; int b; int max; int min;
do{
    Console.WriteLine("Let's find out which numbers are even and which are odd)))");
    Console.Write("Enter number: ");
    a = Convert.ToInt32(Console.ReadLine());
    b = a % 2;

    if(b == 1){
        Console.WriteLine($"Entered number {a} is odd");
    }
    else{
        Console.WriteLine($"Entered number {a} is even");
    }

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
