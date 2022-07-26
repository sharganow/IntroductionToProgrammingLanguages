// Задача №67:
// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его чисел.

Console.Clear();
Console.Write("Set number: ");
int num = int.Parse(Console.ReadLine());
int sum;

sum             = SumDigitalNumber  ( num );
         Console. WriteLine         ( $"{num} -> {sum}" );

int SumDigitalNumber(int num){
    if(num == 0) return 0;
    else{
        return SumDigitalNumber(num/10) + num%10;
    }
}