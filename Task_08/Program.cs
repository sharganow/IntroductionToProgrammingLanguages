// See https://aka.ms/new-console-template for more information
/**************************************************************
*   Задача: Напишите программу, которая на вход принимает число
*   N, а в последующем выводит все чётные числа стоящие перед ним
*   и его само, но кроме нуля
***************************************************************/
int n; int lesserThanN;
Console.WriteLine("Hello, User!");
Console.Beep(); Console.Beep(); Console.Beep();
Console.Write("Enter any positive number, preferably integer and without letters: ");
n = Convert.ToInt32(Console.ReadLine());

if(n < 0){
    n = 0 - n;
}

lesserThanN = 2;
while(lesserThanN < n){
    Console.Write       ($" {lesserThanN} ");
    lesserThanN += 2;
}
if(lesserThanN == n){
    Console.WriteLine   ($" {lesserThanN}   ");
}
else{
    Console.WriteLine   ($" ");
}
    

 Console.WriteLine("We will be glad to see you again!");
 Console.Beep(); Console.Beep();    // УРА!
