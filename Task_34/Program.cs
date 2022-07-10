// Задача №34:
// Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Random rnd = new Random();
int size = rnd.Next(2, 11);
int[] randomeMassive;
int evenNumber;
string viewAnswer;

randomeMassive      = FillRandomeMassive        (size, 100, 999);
evenNumber          = FindEvenNumberInMassive   (randomeMassive);
viewAnswer          = ShowAnswerEvenElements    (randomeMassive, evenNumber);
Console.WriteLine   ( viewAnswer );

int[] FillRandomeMassive(int size, int lowLimit, int highLimit){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(lowLimit, highLimit +1);
    }
    return massive;
}

int FindEvenNumberInMassive(int[] mssv){
    int evenNumber = 0;
    for(int i = 0; i < mssv.Length; i++){
        if(mssv[i] % 2 == 0) evenNumber++;
    }
    return evenNumber;
}

string ShowAnswerEvenElements(int[] massive, int even){
    string viewMassive  = MakeViewStringMassive(massive);
    string viewResult   = "";
    if(even != 0){
        viewResult += $"{even} even numbers found in array";
    }
    else{
        viewResult += "No even numbers found in the array";
    }

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
