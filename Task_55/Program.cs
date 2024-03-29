﻿// Задача №55:
// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае если это невозможно, программа должна вывести сообщение для пользователя.

// P.S. "поворот" матрицы реализовал универсально, соответственно проблемме нет места, 
//      вывожу только результат "наклона" массива

int row         = 3;
int col         = 7;
int arrange     = 0;
int accuracy    = 2;
int min         = -1000;
int max         =  1000;

int [,] matrix;
int [,] rotateMatrix;

matrix              = FillMatrixRndInt(row, col, min, max);
arrange             = GetMaxNumViewSignValue(matrix, accuracy);
rotateMatrix          = RotateMatrix(matrix);

PrintMatrixInt      ( matrix, arrange);
Console.WriteLine   ( "Result of replacing rows with columns:");
PrintMatrixInt      ( rotateMatrix, arrange);

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

int[,] RotateMatrix(int[,] mssv){
    int[,] rotateMatrix;
    rotateMatrix  = new int[mssv.GetLength(1), mssv.GetLength(0)];

    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            rotateMatrix[j, i] = mssv[i, j];
        }
    }

    return rotateMatrix;
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

int GetMaxNumViewSignValue(int[,] mtrx, int accuracy){
    int maxNum = 1;
    int seak;
    for(int i = 0; i < mtrx.GetLength(0); i++){
        for(int j = 0; j < mtrx.GetLength(1); j++){
            seak = GetNumViewSignValue(mtrx[i,j]);
            maxNum = seak > maxNum ? seak : maxNum;
        }
    }
    return maxNum + 2 + accuracy;
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
        ConsoleWriteArrange("]", arrange - accuracy - 2);
        Console.WriteLine("");
    }
}
