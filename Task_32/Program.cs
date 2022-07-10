// Задача №32 
// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Sign replacement in array elements");
int[] randomeMassive;
int[] reverseMassive;
string viewRandomeMassive;
randomeMassive = FillRandomeMassive(4);
reverseMassive = ReverseMassive(randomeMassive);
viewRandomeMassive = ShowResultReverseElements(randomeMassive, reverseMassive);
Console.WriteLine(viewRandomeMassive);

int[] FillRandomeMassive(int size){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(-9,10);
    }
    return massive;
}

int[] ReverseMassive(int[] massive){
    int[] negpos = new int[massive.Length];
    
    for(int i = 0; i < massive.Length; i++){
        negpos[i] = 0 - massive[i];
    }
    return negpos;
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
