// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int [,] matrix;
int sum;

matrix = FillMatrixRndInt(5, 5, -99, 99);
PrintMatrixRndInt(matrix);
sum = FindSumDiagMatrix(matrix);
Console.WriteLine($"Sum of Diagonal Matrix Elements = {sum, 2}");


int[,] FillMatrixRndInt(int row, int col, int min, int max){
    int[,] mssv = new int[row, col];
    Random rnd = new Random();
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            mssv[i,j] = rnd.Next(min, max + 1);
        }   
    }
    return mssv;
}

int FindSumDiagMatrix(int[,] mssv){
    int sum = 0;
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            if(i==j){
                sum += mssv[i,j];
            }
        }   
    }
    return sum;  
}

void PrintMatrixRndInt(int[,] mssv){
    for(int i = 0; i < mssv.GetLength(0); i++){
        Console.Write("[");
        for(int j = 0; j < mssv.GetLength(1); j++){
            if(j < (mssv.GetLength(1) -1)){     Console.Write($"{mssv[i,j], 3}, ");}
            else{                               Console.Write($"{mssv[i,j], 3}");}
        }
        Console.WriteLine("]");
    }
}

