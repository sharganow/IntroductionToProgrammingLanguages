// Задача №33
// Задайте массив.
// Напишите программу, которая определяет, присутствует ли заданное 
// число в массиве
// например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Let's determine if a number is present in the array: ");
int number =int.Parse(Console.ReadLine());
int[] randomeMassive;
string viewAnswer;
randomeMassive = FillRandomeMassive (5, 1, 345);
viewAnswer = MakeAnswerSearchResults(number, randomeMassive);
Console.WriteLine(viewAnswer);

int[] FillRandomeMassive(int size, int lowLimit, int highLimit){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(lowLimit, highLimit +1);
    }
    return massive;
}

int FindNumberInMassive(int number, int[] massive){
    int searchResults = 0;
    for(int i = 0; i < massive.Length; i++){
        if(massive[i] == number) searchResults++;
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

 string MakeAnswerSearchResults(int number, int[] massive){
    string viewResult  = "";
    int searchResult   = FindNumberInMassive(number, massive);
    string viewMassive = MakeViewStringMassive(massive);

    if(searchResult != 0){
        viewResult = $"Yes, the number {number} occurs {searchResult} times";
    }
    else{
        viewResult = $"No, the number {number} does not occur";
    }

    return viewMassive + " -> " + viewResult;
}
