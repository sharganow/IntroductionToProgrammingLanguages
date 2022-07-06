// Задача №29
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33       -> [6, 1, 33]

// P.S. 
// Интересный поворот, в условии явно указано, что массив состоит из 8 элементов, а 
// в приведенных примерах мы наблюдаем вывод введённых массивов из "восьми" элементов:
// в первом случае в массиве 5 элементов, а во втором случае 3 элемента, так же не 
// уточнается принцип ввода массива.
// Вывод: в примере не наблюдаются нули - вероятно при вводе они были, но мы их не наблюдаем в выводе,
// стало быть данное наблюдение принимаем как условие "по умолчанию" или "скрытое"
// и тип ввода поскольку не указан явно в условии выбираю на свое усмотрение - рандомное
// ну диапазон каждого значения не указан, а в примере мы видим 2-х значные числа



Console.WriteLine("В данной задаче вводить ничего не нужно, просто наблюдайте");
int[] randomeMassive = new int[8];
string viewRandomeMassive;
FillRandomeMassive(randomeMassive);
viewRandomeMassive = PrepareViewRandomeMassive(randomeMassive);
Console.WriteLine(viewRandomeMassive);

void FillRandomeMassive(int[] massive){
    for(int i = 0; i< massive.Length; i++){
        massive[i] = new Random().Next(0,100);
    }
}

string PrepareViewRandomeMassive(int[] massive){
    int j = 1;
    string viewMassive = "[";
    string viewInitString = "";
    
    for(int i = 0; i < massive.Length; i++, j++){
        if(massive[i] != 0){
            viewMassive        += Convert.ToString(massive[i]);
            viewInitString     += Convert.ToString(massive[i]);
            if(j != massive.Length){
                viewMassive    += ", ";
                viewInitString += ", ";
            }
        }
    }
    viewMassive += "]";
    viewInitString += " -> ";
    return viewInitString + viewMassive;
}
