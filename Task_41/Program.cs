// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int m;
int[] rangeM;
string answer;

//string[] input = Console.ReadLine().Split(',').ToArray();

Console.Write       ( "Determine how many numbers you want to enter: " );
m                   = Convert.ToInt32(Console.ReadLine());
if(m < 0)           { m = 0 - m; }
if(m == 0)          { m = 1;    Console.WriteLine($"The value cannot be zero, otherwise why did you start this console at all))"); }
rangeM              = new int[m];
rangeM              = UserEntersValues(m);
m                   = CountBiggerZeroValues(rangeM);
answer              = ShowCheckZero(rangeM, m);
Console.WriteLine   ( answer );


int CountBiggerZeroValues(int[] mssv){
    int biggerZero = 0;
    for(int i = 0; i < mssv.Length; i++){
        if(mssv[i] > 0){ biggerZero++;}        
    }
    return biggerZero;
}

int[] UserEntersValues(int num){
    int[] mssv = new int[num];
    for(int i = 0; i < num; i++){
        Console.Write($"Enter value No.{i+1}:  ");
        mssv[i] = Convert.ToInt32(Console.ReadLine());        
    }
    return mssv;
}

string ShowCheckZero(int[] mssv, int biggerZero){
    string viewMassive = MakeViewStringMassive(mssv);
    string viewResult  = $"There are {biggerZero} elements greater than zero in the input array";

    return viewResult + " -> " + viewMassive;
}

string MakeViewStringMassive(int[] massive){
    string viewString = "[";
    int j = 1;
    for(int i = 0; i < massive.Length; i++, j++){
        viewString += Convert.ToString(massive[i]);
        if(j != massive.Length) viewString += ", ";
    }
    viewString += "]";
    return viewString;
}
