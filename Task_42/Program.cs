// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int a;
int[] result;
string answer;


Console.Write       ( "Enter decimal number: ");
a                   = Convert.ToInt32(Console.ReadLine());
result              = ConvertToBool(a);
answer              = MakeViewStringMassive(result);
Console.WriteLine   ( answer );

int[] ConvertToBool(int a){
    int b = a % 512;
    int[] boolean = new int[9];
    int razr = 256;
    for(int i = 0; i < boolean.Length; i++){
        if(b >= razr){
            b = b - razr;
            boolean[i] = 1;
        }
        else{
            boolean[i] = 0;
        }
        razr /= 2;
    }
    return boolean;
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
