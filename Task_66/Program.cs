// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Set number M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Set number N: ");
int numN = int.Parse(Console.ReadLine());
string answer;

answer          = $"M = {numM}; N = {numN}. -> ";
answer         += SumRangeValues    ( numM, numN, 0 );
         Console. Write             ( answer );

string SumRangeValues(int m, int n, int sum)
{
    if( m == n ){
        sum += m;
        return Convert.ToString(sum);
    }
    else{
        if(m < n){
            sum += m;
            m++; 
            
        }
        else{
            sum += n;
            n++;           
        }
        return "" + SumRangeValues( m, n, sum );
    }
}
