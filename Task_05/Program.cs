// See https://aka.ms/new-console-template for more information
// Написать программукоторая на вход принимает одно число N, а
// на выходе показывает все целые числа в промежутке от -N до N
int n;
int outN;
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
Console.Write("Enter any number, preferably integer and without letters: ");
n = Convert.ToInt32(Console.ReadLine());
if(n > 0){
    outN = 0 - n;
}else{
    outN = n;
    n *= (-1);
}
do{
    Console.Write       ($" {outN++} ");
}while(outN != n);
    Console.WriteLine   ($" {outN}   ");

 Console.WriteLine("We will be glad to see you again!");
 Console.Beep(); Console.Beep();    // УРА!
