// Задача №59:
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и с толбец, 
// на пересечении которых расположен наименьший элемент массива.

// P.S. В одной из задач в домашнем задании есть задача формирования массива 
// из уникальных не повторяющихся случайных чисел, я решил применить это свойство 
// в данной задаче, т.к. это не противоречит условию данной, избавит от необходимости
// в организации принятия решения по выбору конкретного числа, если минимут повторяется
// и создаст функцию для домашней задачи

int row         = 3;
int col         = 7;
int arrange     = 0;
int min         = -1000;
int max         =  1000;
int[] coordMinValue = new int[2] {row, col};

int [,] matrix;

matrix              = FillMatrixRndInt       ( row, col, min, max );
arrange             = GetMaxNumViewSignValue ( matrix );
PrintMatrixInt      ( matrix, arrange );
coordMinValue       = FindMinValueCoord      ( matrix );
Console.Write   ( $"X:{coordMinValue[0],  3}, Y:{coordMinValue[1],  3}" );
Console.WriteLine("");

matrix              = CutMatrix              ( matrix, coordMinValue);
PrintMatrixInt      ( matrix, arrange );/**/



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

int[,] CutMatrix(int[,] mtrx, int[] coord){
    int [,] mssv = new int[mtrx.GetLength(0)-1, mtrx.GetLength(1)-1];
    int iRx = 0;
    int jRx = 0;
    for(int i = coord[0] + 1; i < mtrx.GetLength(0); i++){
        iRx = i -1;
        for(int j = 0; j < mtrx.GetLength(1); j++){
            mtrx[iRx, j] = mtrx[i, j];
        }
    }
    for(int i = 0; i < mtrx.GetLength(0) -1 ; i++){
        for(int j = coord[1] + 1; j < mtrx.GetLength(1); j++){
            jRx = j - 1;
            mtrx[i, jRx] = mtrx[i, j];
        }
    }
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
             mssv[i, j] = mtrx[i, j];
        }
    }
    return mssv;  
}

int[] FindMinValueCoord(int[,] mtrx){
    int[] coord = new int[2] {0, 0};
    for(int i = 0; i < mtrx.GetLength(0); i++){
        for(int j = 0; j < mtrx.GetLength(1); j++){
            if (mtrx[i,j] < mtrx[coord[0], coord[1]]){
                coord[0] = i;
                coord[1] = j;
            }
        }   
    }
    return coord;
} 

// bool IsThereValue(int[,] mssv, int maxRow, int maxCol, int Value){
//     int endCol;
//     for(int i = 0; i <= maxRow; i++){
//         endCol = i == maxRow ? maxCol : mssv.GetLength(1) - 1;
//         for(int j = 0; j <= endCol; j++){
//             if (mssv[i,j] == Value) return true;
//         }   
//     }
//     return false;
// }

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