// Задача №24
// Напишите программу, которая принимает на вход
// Число (А) и выдает сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Enter, a number: ");
int a = int.Parse(Console.ReadLine());          //Convert.ToInt32(console.ReadLine());
int res = Sum(a);


Console.WriteLine($"Sum numbers from 1 to {a} = {res}");

int Sum(int num){
    int sum = 0;
    for(int i = 1; i <= num; i++){
        sum = sum +i;
    }
    return sum;
}
