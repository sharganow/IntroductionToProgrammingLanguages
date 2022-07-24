// Дополнительная задача
// Задача №61:
// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

int row         = 9;
int arrange     = 0;

int [,] matrix;

matrix              = FillMatrixPascal          ( row );
arrange             = GetMaxNumViewSignValue    ( matrix );
                      PrintMatrixInt            ( matrix, arrange );

int[,] FillMatrixPascal(int row){
    int col;
    if(row == 0){
        row = 1;
        col = (row * 2) + 1;
    }
    else{
        col = (row * 2) + 1;
    }
    int[,] mssv = new int[row, col];
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            mssv[i,j] = 0;
        }
    }
    mssv[0,row] = 1;
    for(int i = 1; i < mssv.GetLength(0); i++){
        for(int j = 1; j < mssv.GetLength(1)-1; j++){
            mssv[i,j] = mssv[i-1,j-1] + mssv[i-1,j+1];
        }
    }
    return mssv;    
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
    return maxNum;
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
            if(mssv[i,j] == 0){
                strPprint = " ";
            }
            else{
                strPprint = Convert.ToString(mssv[i,j]);
            }            
            ConsoleWriteArrange(strPprint, arrange);
            //if(j < (mssv.GetLength(1) -1)){   Console.Write(",");}
        }
        ConsoleWriteArrange("]", arrange - 1);
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
