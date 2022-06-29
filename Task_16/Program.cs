// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого
//     5, 25 -> да
//    -4, 25 -> нет
//     25, 5 -> да
//      8, 9 -> нет
Console.WriteLine("Hello, User!");
string quit, answerOut;
char quitRepite = 'n';
int first; int second;
do{
    Console.WriteLine("Let's check if one of the entered numbers is the square of the other?");
    Console.Write("Enter first  number: ");
    first = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    second = Convert.ToInt32(Console.ReadLine());
    answerOut = Convert.ToString(first) + ", " + Convert.ToString(second);
    vOutResult(bFindSquare(first, second), answerOut);

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

 bool bFindSquare(int a, int b){
    if(a == (b*b)){     return true;  }
    else{
        if(b == (a*a)){ return true;  }
        else{           return false; }
    }
 }

 void vOutResult(bool b, string s){
    if(b){  s += " -> да" ;  }
    else{   s += " -> нет";  }
    Console.WriteLine(s);
 }
 // УРА!
