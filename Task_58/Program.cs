// Задача №58:
// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

int row         = 2;
int col         = 3;
int arrange     = 0;
int min         = -1;
int max         =  9;

int [,] matrixA;
int [,] matrixB;
int [,] matrixC;

matrixA              = FillMatrixRndInt          ( row, col, min, max );
matrixB              = FillMatrixRndInt          ( col, row, min, max );
              Console. WriteLine                 ( "We have matrix A:");
arrange              = GetMaxNumViewSignValue    ( matrixA );
                       PrintMatrixInt            ( matrixA, arrange );
              Console. WriteLine                 ( "And we have matrix B:");
arrange              = GetMaxNumViewSignValue    ( matrixB );
                       PrintMatrixInt            ( matrixB, arrange );
matrixC              = MtrxAmulMtrxB             ( matrixA, matrixB );
              Console. WriteLine                 ( "The result of multiplying these two matrices:");
arrange              = GetMaxNumViewSignValue    ( matrixC );
                       PrintMatrixInt            ( matrixC, arrange );                  

int[,] FillMatrixRndInt(int row, int col, int min, int max){
    int[,] mssv = new int[row, col];
    int[] allVallues = new int[max - min];
    int iAllVallues = -1;
    Random rnd = new Random();
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            int seak = iAllVallues;
            do{
                int value = rnd.Next( min, max + 1 );
                if(!IsThereValue(allVallues, iAllVallues, value)){
                    mssv[i,j] = value;
                    iAllVallues++;
                    if(iAllVallues < allVallues.Length){
                        allVallues[iAllVallues] = value;
                    }                    
                    seak = allVallues.Length;
                }
                else{
                    if(iAllVallues == allVallues.Length){
                        mssv[i,j] = max;    // массив всёравно заполнить нужно, плюс мы отразим переполнение значений
                    }
                }                
            }while(seak < allVallues.Length);
        }   
    }
    return mssv;
}

bool IsThereValue(int[] mssv, int maxCol, int value){
    if( maxCol == -1) return false;
    else{
        if( maxCol >= mssv.Length ){    return true;}
        else{
            for(int j = 0; j <= maxCol; j++){
                if (mssv[j] == value) return true;
            }
            return false;
        }
    }
}

int GetMaxNumViewSignValue(int[,] mtrx){
    int maxNum = 1;
    int seak;
    for(int i = 0; i < mtrx.GetLength(0); i++){
        for(int j = 0; j < mtrx.GetLength(1); j++){
            seak = GetNumViewSignValue(mtrx[i,j]);
            maxNum = seak > maxNum ? seak : maxNum;
        }
    }
    return maxNum + 2;
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
    while(value > 10){
        value /= 10;
        numSign += 1;
    }
    return numSign;
}

void PrintMatrixInt(int[,] mssv, int arrange){
    String strPprint;
    for(int i = 0; i < mssv.GetLength(0); i++){
        ConsoleWriteArrange("[", 1);
        for(int j = 0; j < mssv.GetLength(1); j++){
            strPprint = Convert.ToString(mssv[i,j]);
            ConsoleWriteArrange(strPprint, arrange);
            //if(j < (mssv.GetLength(1) -1)){   Console.Write(",");}
        }
        ConsoleWriteArrange("]", arrange - 2);
        Console.WriteLine("");
    }
}

void ConsoleWriteArrange(string print, int arrange){
    switch(arrange){
        case 0:     Console.Write($"{print,  0}"); break;
        case 1:     Console.Write($"{print,  1}"); break;
        case 2:     Console.Write($"{print,  2}"); break;
        case 3:     Console.Write($"{print,  3}"); break;
        case 4:     Console.Write($"{print,  4}"); break;
        case 5:     Console.Write($"{print,  5}"); break;
        case 6:     Console.Write($"{print,  6}"); break;
        case 7:     Console.Write($"{print,  7}"); break;
        case 8:     Console.Write($"{print,  8}"); break;
        case 9:     Console.Write($"{print,  9}"); break;
        case 10:    Console.Write($"{print, 10}"); break;
        case 11:    Console.Write($"{print, 11}"); break;
        case 12:    Console.Write($"{print, 12}"); break;
        case 13:    Console.Write($"{print, 13}"); break;
        default:    Console.Write($"{print, 15}"); break;
    }
}

int[,] MtrxAmulMtrxB(int [,] mtrxA, int [,] mtrxB){
    int [,] mtrxC = new int[mtrxA.GetLength(0),mtrxB.GetLength(1)];
    if(mtrxA.GetLength(1) != mtrxB.GetLength(0)){
        Console. WriteLine                 ( "Matrices cannot be multiplied");
        return mtrxA;
    }
    else{  
        for(int i = 0; i < mtrxA.GetLength(0); i++){
            int sumCiAjB;
            for(int j = 0; j < mtrxB.GetLength(1); j++){
                sumCiAjB = 0;
                for(int ij = 0; ij < mtrxB.GetLength(0); ij++){
                    sumCiAjB += mtrxA[i,ij] * mtrxB[ij,j];
                }
                mtrxC[i,j] = sumCiAjB;
            }
        }
        return mtrxC;
    }
}
