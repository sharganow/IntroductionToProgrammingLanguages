// Задача № 37
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпследний и т.д.
// Результат запишите в одномерном массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Random rnd = new Random();
int size = rnd.Next(2, 11);
int[] randomeMassive;
int[] opositeMultipleMassive;
string viewRandomeMassive;

randomeMassive          = FillRandomeMassive                ( size,             0,                      10 );
opositeMultipleMassive  = MultiplyingExtremeElementsArray   ( randomeMassive                                );
viewRandomeMassive      = ShowResultReverseElements         ( randomeMassive,  opositeMultipleMassive     );
Console.WriteLine       ( viewRandomeMassive );

int[] FillRandomeMassive(int size, int lowLimit, int highLimit){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(lowLimit, highLimit +1);
    }
    return massive;
}

int[] MultiplyingExtremeElementsArray(int[] massive){
    int sizeArray = (massive.Length / 2) + (massive.Length %2);
    int[] array = new int[sizeArray];
    int j = sizeArray - 1;
    int i = 0;
    for(i = 0; i < j; i++, j--){
        array[i] = /*massive[*/i++/*] /** massive[j--]*/;
    }
    if(i == j){
        array[i] = massive[i];
    }
    return array;
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
