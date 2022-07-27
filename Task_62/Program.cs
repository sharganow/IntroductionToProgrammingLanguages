﻿// Задача №62:
// Заполните спирально массив 4 на 4.

int row         = 6;
int col         = 5;
int arrange     = 0;

int [,] matrix;
matrix              = FillMatrixRoundInt        ( row, col );
arrange             = GetMaxNumViewSignValue    ( matrix );
                      PrintMatrixInt            ( matrix, arrange );

int[,] FillMatrixRoundInt(int row, int col){
    int[,] mssv = new int[row, col];
    int iVallue = 1;
    int iLow = 0;
    int iHig = mssv.GetLength(0) - 1;
    int jLow = 0;
    int jHig = mssv.GetLength(1) - 1;
    int direction = 0;
    while(iVallue <= mssv.Length){
        switch(direction){
            case 0:{//Движение слева на право
                for(int j = jLow; j <= jHig; j++){
                    mssv[iLow, j] = iVallue++;
                }
                iLow++;
            }break;
            case 1:{//Движение сверху вниз
                for(int i = iLow; i <= iHig; i++){
                    mssv[i, jHig] = iVallue++;
                }
                jHig--;
            }break;
            case 2:{//Движение справа на лево
                for(int j = jHig; j >= jLow; j--){
                    mssv[iHig, j] = iVallue++;
                }
                iHig--;
            }break;
            case 3:{//Движение снизу вверх
                for(int i = iHig; i >= iLow; i--){
                    mssv[i, jLow] = iVallue++;
                }
                jLow++;
            }break;
            default:{
                direction = -1;
            }break; 
        }
        direction++;
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