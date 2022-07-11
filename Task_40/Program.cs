// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int a;
int b;
int c;
bool able;      // признак возможности существования треугольника
string answer;

Console.Write("Введите первую сторону треугольника А: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую сторону треугольника В: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую сторону треугольника С: ");
c = Convert.ToInt32(Console.ReadLine());

able = CheakAbilityTriacl(a, b, c);
answer = ShowAnswer(able);
Console.WriteLine(answer);


bool CheakAbilityTriacl(int a, int b, int c)
{
    if(a < (b + c) && b < (a + c)&& c < (a+b)){
        return true;
    }
    else{
        return false;
    }
}

string ShowAnswer(bool ability){
    if(ability){
        return "Треугольник Возможен";
    }
    else{
        return "Треугольник Не Возможен";
    }
}





