// Задача 64: 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Set number: ");
int num = int.Parse(Console.ReadLine());
string answer;

answer          = $"N = {num} -> " + Convert.ToString('"');
answer         += DescendingString  ( num );
         Console. Write             ( answer );

string DescendingString(int n)
{
    if(n == 1){ 
        return "1" + Convert.ToString('"');
    }
    else{
        return Convert.ToString(n) + ", " + DescendingString( n - 1);
    }
}
