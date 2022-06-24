// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
string quit;
char quitRepite = 'n';
int A; int B; int squareB;
do{
    Console.WriteLine("Let's check: is the number A the square of the number B?");
    Console.Write("Enter number A: ");
    A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number B: ");
    B = Convert.ToInt32(Console.ReadLine());
    squareB = B * B;
    if(squareB == A){
        Console.WriteLine("Yes, the number A is the square of the number B!");
    }
    else{
        Console.WriteLine("No, the number A is not the square of the number B!");
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
