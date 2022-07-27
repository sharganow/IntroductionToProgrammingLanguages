// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Set number M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Set number N: ");
int numN = int.Parse(Console.ReadLine());
int akerMan;
string answer;

answer      = $"m = {numM}, n = {numN} -> A(m,n) = ";
akerMan     =         A         ( numM, numN );
answer     += Convert.ToString  ( akerMan );
     Console. Write             ( answer );

int A(int m, int n)
{
    if(m==0){
        return n+1;
    }
    else{
        if((m>0)&&(n==0)){
            return A(m-1,1);
        }
        else{
            return A(m-1, A(m, n-1));
        }
    }
}