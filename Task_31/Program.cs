// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива. Например в массиве 
// [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]  сумма положительных
// чисел равна 29, сумма отрицательных равна -20.

Console.WriteLine("Программа генерирует случайным образом массив из 12 элементов");
int[] randomeMassive = new int[12];
int[] sum;
string viewRandomeMassive;
viewRandomeMassive = FillRandomeMassive(randomeMassive);
sum = SumNegPosElements(randomeMassive);
Console.WriteLine(viewRandomeMassive + $" Сумма отрицательных чисел равна {sum[0]}, а сумма положительных чисел равна {sum[1]}");

string FillRandomeMassive(int[] massive){
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(-9,10);
    }
    int j = 1;
    string viewMassive = "В массиве [";
    
    for(int i = 0; i < massive.Length; i++, j++){
        viewMassive += Convert.ToString(massive[i]);
        if(j != massive.Length)viewMassive += ", ";
    }
    viewMassive += "]";
    return viewMassive;
}

int[] SumNegPosElements(int[] massive){
    int[] negpos = new int[2] {0,0};
    
    for(int i = 0; i < massive.Length; i++){
        if(massive[i] < 0){
            negpos[0] += massive[i];
        }
        else{
            negpos[1] += massive[i];
        }
    }
    return negpos;
}

// string ShowResult(){

// }
