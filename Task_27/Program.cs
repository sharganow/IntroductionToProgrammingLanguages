// Задача №27
// Напишите программу, которая принимает на вход число
// и выдает сумму цифр в числе


Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
int sum;
sum = SumElements(number);
Console.WriteLine($"Сумма всех разрядов числа {number} равна {sum}");

int SumElements(int n){
    int res = 0;
    do{
        res += n % 10;
        n /= 10;
    }while(n != 0);
    return res;
}
