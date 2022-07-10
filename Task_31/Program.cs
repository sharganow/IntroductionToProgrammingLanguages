// Задача №31
// 1. Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и  положительных элементов массива. 
// 3. Вывести в консоль результат. Например в массиве 
// [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]  сумма положительных
// чисел равна 29, сумма отрицательных равна -20.

Console.WriteLine("The program randomly generates an array of 12 elements");
int[] randomeMassive;
int[] sum;
string viewRandomeMassive;
randomeMassive = FillRandomeMassive(12);
sum = SumNegPosElements(randomeMassive);
viewRandomeMassive = ShowResultSumNegPosElements(randomeMassive, sum);
Console.WriteLine(viewRandomeMassive);

int[] FillRandomeMassive(int size){
    int[] massive = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = rnd.Next(-9,10);
    }
    return massive;
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

 string ShowResultSumNegPosElements(int[] massive, int[] math){
    int j = 1;
    string viewMassive = "In the array [";
    string viewResult = "";
    for(int i = 0; i < massive.Length; i++, j++){
        viewMassive += Convert.ToString(massive[i]);
        if(j != massive.Length)viewMassive += ", ";
    }
    viewMassive += "] ";
    viewResult = " the sum of negative elements is " + Convert.ToString(math[0]);
    viewResult += " and the sum of positive elements is " + Convert.ToString(math[1]);
    return viewMassive + viewResult;
}
