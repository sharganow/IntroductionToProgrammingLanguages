// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Random rnd = new Random();
int size = rnd.Next(2, 11);
int[]   randomeMassive;
int[]   reverseMassive;
double     amplitude;
string  viewAnswer;

randomeMassive   = FillRandomeMassive(size, -100, 100);
reverseMassive   = ReverseMassive(randomeMassive);
viewAnswer       = ShowResultReverseElements(randomeMassive, reverseMassive);
Console.WriteLine( viewAnswer );
randomeMassive   = ReverseMassive(randomeMassive);
viewAnswer       = ShowResultReverseElements(randomeMassive, reverseMassive);
Console.WriteLine( viewAnswer );


int[] FillRandomeMassive(int size, int lowLimit, int highLimit){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(lowLimit, highLimit +1);
    }
    return massive;
}

int[] ReverseMassive(int[] mssv){
    int[] vssm = new int[mssv.Length];
    int j = mssv.Length - 1;
    for(int i = 0; i < mssv.Length; i++, j--){
        vssm[i] = mssv[j];
    }
    return vssm;
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
