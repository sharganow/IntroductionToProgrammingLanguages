// Задача №46:
// Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами


int [,] matrix;

matrix = FillMatrixRndInt(3, 4, -9, 9);
PrintMatrixInt(matrix);

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
