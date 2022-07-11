// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


Random rnd = new Random();
int size = rnd.Next(2, 11);
int[]   randomeMassive;
int[]   copyMassive;
double     amplitude;
string  viewAnswer;

randomeMassive   = FillRandomeMassive(size, -100, 100);
copyMassive      = CopyMassive(randomeMassive);
viewAnswer       = ShowResultReverseElements(randomeMassive, copyMassive);
Console.WriteLine( viewAnswer );

int[] FillRandomeMassive(int size, int lowLimit, int highLimit){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(lowLimit, highLimit + 1);
    }
    return massive;
}

int[] CopyMassive(int[] mssv){
    int[] copy = new int[mssv.Length];
    for(int i = 0; i < mssv.Length; i++){
        if(i == 1){
            copy[i] = 444;
        }
        else{
            copy[i] = mssv[i];
        }
    }
    return copy;
}

string ShowResultReverseElements(int[] massive, int[] antiMassive){
    string viewMassive = MakeViewStringMassive(massive);
    string viewResult  = MakeViewStringMassive(antiMassive);

    return viewMassive + " -> " + viewResult;
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
