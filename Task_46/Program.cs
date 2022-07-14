
int [,] matrix;

matrix = FillMatrixRndInt(3, 4, 9, 0);
PrintMatrixRndInt(matrix);

int[,] FillMatrixRndInt(int row, int col, int max, int min){
    int[,] mssv = new int[row, col];
    Random rnd = new Random();
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            mssv[i,j] = rnd.Next(min, max + 1);
        }   
    }
    return mssv;
}

void PrintMatrixRndInt(int[,] mssv){
    for(int i = 0; i < mssv.GetLength(0); i++){
        Console.Write("[");
        for(int j = 0; j < mssv.GetLength(1); j++){
            Console.Write(mssv[i,j]);
            if(j < (mssv.GetLength(1) -1)){   Console.Write(", ");}
        }
        Console.WriteLine("]");
    }
}

