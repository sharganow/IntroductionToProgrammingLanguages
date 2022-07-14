// Задача №47:
// Задайте двумерный массив размереом M x N,
// заполненный случайными вещественными числами

double [,] matrix;
int accuracy    = 3;
int min         = -100;
int max         =  100;

matrix = FillMatrixRndDouble(3, 4, -9, 9);
PrintMatrixInt(matrix);

double[,] FillMatrixRndDouble(int row, int col, int min, int max){
    double[,] mssv = new int[row, col];
    Random rnd = new Random();
    int amplitude = max - min;
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            mssv[i,j] = amplitude * rnd.NextDouble();
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

int GetNumViewSignValue(int value){
    int numSign;
    if( value < 0 ){
        value = 0 - value;
        numSign = 2;
    }
    else{
        numSign = 1;
    }
    while(value > 0){
        value /= 10;
        numSign += 1;
    }
    return numSign;
}

int GetMaxNumViewSignValue(double[,] mtrx, int accuracy){
    int maxNum = 1;
    int seak;
    for(int i = 0; i < mtrx.GetLength(0); i++){
        for(int j = 0; j < mtrx.GetLength(1); j++){
            seak = GetNumViewSignValue((int)mtrx[i,j]);
            maxNum = seak > maxNum ? seak : maxNum;
            mtrx[i,j] = Math.Round(mtrx[i,j], accuracy);
        }
    }
    return maxNum + accuracy + 1;
}