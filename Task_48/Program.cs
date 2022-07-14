// Задача №48
// Задайте двумерный массив размера m x n,
// каждый элемент в массиве находится по формуле:
// Amn = m + n.
// Выведите полученный массив на экран.

int [,] matrix;

matrix = MakeMatrixFunct(3, 4);
PrintMatrixInt(matrix);

int[,] MakeMatrixFunct(int row, int col){
    int[,] mssv = new int[row, col];
    Random rnd = new Random();
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            mssv[i,j] = i + j;
        }   
    }
    return mssv;
}

void PrintMatrixInt(int[,] mssv){
    for(int i = 0; i < mssv.GetLength(0); i++){
        Console.Write("[");
        for(int j = 0; j < mssv.GetLength(1); j++){
            Console.Write($"{mssv[i,j], 3}");
            if(j < (mssv.GetLength(1) -1)){   Console.Write(", ");}
        }
        Console.WriteLine("  ]");
    }
}
