// Задача №69:
// Напишите программу, которая на вход принимает два числа: A и B.
// И возводит число А в целую степень В с помощью рекурсии:

Console.Clear();
Console.Write("Set number A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Set number B: ");
int numB = int.Parse(Console.ReadLine());
int expAB;

expAB           = AexpB           ( numA, numB );
         Console. WriteLine       ( $"{numA}^{numB} -> {expAB}" );

int AexpB(int nA, int nB){
    if(nB == 0) return 1;
    else{
        return AexpB(nA, nB-1) * nA;
    }
}