// Задача №35
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значение которых лежат в отрезке [10, 99].

int lowLim  = int.Parse(Console.ReadLine());
int highLim = int.Parse(Console.ReadLine());
if(lowLim > highLim){
    int i   = lowLim;
    lowLim  = highLim;
    highLim = i;
}
Console.WriteLine($"How many array elements belong to the segment from {lowLim} to {highLim}");

int[] randomeMassive;
string viewAnswer;
randomeMassive = FillRandomeMassive (123, 0, 345);
viewAnswer = MakeAnswerSearchResults(randomeMassive, lowLim, highLim);
Console.WriteLine(viewAnswer);

int[] FillRandomeMassive(int size, int lowLimit, int highLimit){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(lowLimit, highLimit +1);
    }
    return massive;
}

int FindNumberInMassive(int[] massive, int lowLimit, int highLimit){
    int searchResults = 0;
    for(int i = 0; i < massive.Length; i++){
        if(massive[i] >= lowLimit && massive[i] <= highLimit) searchResults++;
    }
    return searchResults;
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

 string MakeAnswerSearchResults(int[] massive, int lowLimit, int highLimit){
    string viewResult  = "";
    int searchResult   = FindNumberInMassive(massive, lowLimit, highLimit);
    string viewMassive = MakeViewStringMassive(massive);

    if(searchResult != 0){
        viewResult = $"{searchResult} elements belong to the segment from {lowLimit} to {highLimit}";
    }
    else{
        viewResult = $"There are no elements in the array in the range of values from {lowLimit} to {highLimit}";
    }

    return viewMassive + " -> " + viewResult;
}
