/**************************************************************
*   Задача: Напишите программу, которая преобразует трёх-
*   значное введённое число (по условию и под ответственность пользователя),
*   и преобразует его в двухзначное путём исключения второго символа
    456 -> 46
    782 -> 72
    918 -> 98
***************************************************************/
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
string quit;
char quitRepite = 'n';
int a; int b;
do{
    Console.Write("Enter a three-digit number: ");
    a = Convert.ToInt32(Console.ReadLine());
    b = ((a - (a % 100))/10) + (a % 10);
    Console.WriteLine($"Преобразованное число выглядит так: {b}");

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
