// Задача №65:
// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные значения от 
// M до N.

Console.Clear();
Console.Write("Set number M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Set number N: ");
int numN = int.Parse(Console.ReadLine());

NaturalNumber(numN, numM);

void NaturalNumber(int num, int mun){
    if(num == mun){
        Console.Write($"{mun}");
    } 
    else{
        if(num > mun){
            Console.Write($"{mun}");
            NaturalNumber(num, mun+1);
        }
        else{
            Console.Write($"{num}");
            NaturalNumber(num+1, mun);            
        }
    }
}