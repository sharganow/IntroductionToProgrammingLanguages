// Задача№36:
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12]  -> 19
// [-4, -6, 89, 6] -> 0

Random rnd = new Random();
int size = rnd.Next(2, 11);
int[]   randomeMassive;
int     sumOddElements;
string  viewAnswer;

randomeMassive      = FillRandomeMassive        (size, -99, 99);
sumOddElements      = SumOddElementsInMassive   (randomeMassive);
viewAnswer          = ShowSumOddElements        (randomeMassive, sumOddElements);
Console.WriteLine   ( viewAnswer );

int[] FillRandomeMassive(int size, int lowLimit, int highLimit){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(lowLimit, highLimit +1);
    }
    return massive;
}

int SumOddElementsInMassive(int[] mssv){
    int sum = 0;
    for(int i = 1; i < mssv.Length; i += 2){
        sum += mssv[i];
    }
    return sum;
}

string ShowSumOddElements(int[] massive, int sum){
    string viewMassive  = MakeViewStringMassive(massive);
    string viewResult   = "";
    viewResult         += $"The sum of positionally odd elements is equal to {sum}";
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
