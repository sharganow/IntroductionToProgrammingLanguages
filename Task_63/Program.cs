// Задача №63:
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке
// от 1 до N.

Console.Clear();
Console.Write("Set number: ");
int num = int.Parse(Console.ReadLine());

NaturalNumber(num);

void NaturalNumber(int num){
    if(num == 0) return;
    else{
        NaturalNumber(num - 1);
        Console.Write($"{num}");
    }
}