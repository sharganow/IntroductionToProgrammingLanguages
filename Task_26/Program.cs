// Задача №26
// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456     -> 3
// 78      -> 2
// 89126   -> 5

Console.Write("Введите скольугодно значное число: ");
int enteredNumber = int.Parse(Console.ReadLine());
int result = ReturnRangeNumber(enteredNumber);
Console.WriteLine($"Разрядность введенного числа составляет {result}");


int ReturnRangeNumber(int n){
    int rangeNumber = 0;
    if(n < 0) n = 0 - n;
    do{
        n /= 10;
        rangeNumber++;
    }while(n > 0);
    return rangeNumber;
}
