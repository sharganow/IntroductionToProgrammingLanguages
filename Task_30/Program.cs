// Задача №30
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

Console.WriteLine("В данной задаче вводить ничего не нужно, просто наблюдайте");
int[] randomeMassive = new int[8];
string viewRandomeMassive;
FillRandomeMassive(randomeMassive);
viewRandomeMassive = PrepareViewRandomeMassive(randomeMassive);
Console.WriteLine(viewRandomeMassive);

void FillRandomeMassive(int[] massive){
    for(int i = 0; i< massive.Length; i++){
        massive[i] = new Random().Next(0,2);
    }
}

string PrepareViewRandomeMassive(int[] massive){
    int j = 1;
    string viewMassive = "[";
    
    for(int i = 0; i < massive.Length; i++, j++){
        viewMassive += Convert.ToString(massive[i]);
        if(j != massive.Length)viewMassive += ", ";
    }
    viewMassive += "]";
    return viewMassive;
}

