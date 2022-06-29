// See https://aka.ms/new-console-template for more information
// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. Если число 2 не 
// кратно числу 1, то программа выводит остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Hello, User!");
string quit;
char quitRepite = 'n';
int first; int second; int remainder;
do{
    Console.WriteLine("let's determine the multiplicity of the second number to the first.");
    Console.Write("Enter first number: ");
    first = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    second = Convert.ToInt32(Console.ReadLine());
    remainder = first % second;
    if(remainder != 0){
        Console.WriteLine($"{first}, {second} -> не кратно, остаток {remainder}");
    }
    else{
        Console.WriteLine($"{first}, {second} -> кратно");
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
