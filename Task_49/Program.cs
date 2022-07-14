// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int [,] matrix;

matrix = FillMatrixRndInt(5, 5, -9, 9);
PrintMatrixRndInt(matrix);
Console.WriteLine(" ");
matrix = CorrectMatrix(matrix);
PrintMatrixRndInt(matrix);

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

int[,] CorrectMatrix(int[,] mssv){
    int[,] mtrx = new int[mssv.GetLength(0), mssv.GetLength(1)];
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            if(i%2==0 && j%2==0){
                mtrx[i,j] = (int) Math.Pow(mssv[i,j], 2);
            }
            else{
                mtrx[i,j] = mssv[i,j];
            }
        }   
    }
    return mtrx;
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

