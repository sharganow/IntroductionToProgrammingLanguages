// See https://aka.ms/new-console-template for more information
/**************************************************************
*   Задача: Написать программу в которой через консоль принимается
*   два числа, затем они сравниваются между собой с целью 
*   выявления большего и соответственно меньшего числа и выводится
*   обратно в консоль результат сравнения
***************************************************************/
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
string quit;
char quitRepite = 'n';
int a; int b; int max; int min;
do{
    Console.WriteLine("Let's compare two numbers and find the larger one.");
    Console.Write("Enter number A: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number B: ");
    b = Convert.ToInt32(Console.ReadLine());
    if(a > b){
        Console.WriteLine($"The number A is greater than the number B, the maximum value max = {a}");
    }
    else{
        if(a < b){
            Console.WriteLine($"The number B is greater than the number A, the maximum value max = {b}");
        }
        else{
            Console.WriteLine($"The numbers are equal");
        }
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
