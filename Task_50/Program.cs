// Задача №50: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

double [,]  matrix;
string[]    input;
string      answer;
int row         = 4;
int col         = 6;
int arrange     = 0;
int accuracy    = 3;
int min         = -1000;
int max         =  1000;

matrix          = FillMatrixRndDouble( row, col, min, max );
arrange         = GetMaxNumViewSignValue( matrix, accuracy );
PrintMatrixInt  ( matrix, arrange );
answer          = "Specify, separated by commas, the coordinates of an element in a two-dimensional array: ";
Console.Write   ( answer );
input           = Console.ReadLine().Split(',').ToArray();
answer          = GetValueFromMatrix(input, matrix);
Console.Write   ( answer );


double[,] FillMatrixRndDouble(int row, int col, int min, int max){
    double[,] mssv = new double[row, col];
    Random rnd = new Random();
    int amplitude = max - min;
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            mssv[i,j] = min + amplitude * rnd.NextDouble();
        }   
    }
    return mssv;
}

void PrintMatrixInt(double[,] mssv, int arrange){
    String strPprint;
    for(int i = 0; i < mssv.GetLength(0); i++){
        ConsoleWriteArrange("[", 1);
        for(int j = 0; j < mssv.GetLength(1); j++){
            strPprint = Convert.ToString(mssv[i,j]);
            strPprint = ReplaceCommaWithDot(strPprint);
            ConsoleWriteArrange(strPprint, arrange);
            if(j < (mssv.GetLength(1) -1)){   Console.Write(",");}
        }
        ConsoleWriteArrange("]", arrange - accuracy - 2);
        Console.WriteLine("");
    }
    //Console.Write($"arrange = {arrange}");
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
    return maxNum + accuracy + 2;
}

void ConsoleWriteArrange(string print, int arrange){
    switch(arrange){
        case 0:     Console.Write($"{print, 0}"); break;
        case 1:     Console.Write($"{print, 1}"); break;
        case 2:     Console.Write($"{print, 2}"); break;
        case 3:     Console.Write($"{print, 3}"); break;
        case 4:     Console.Write($"{print, 4}"); break;
        case 5:     Console.Write($"{print, 5}"); break;
        case 6:     Console.Write($"{print, 6}"); break;
        case 7:     Console.Write($"{print, 7}"); break;
        case 8:     Console.Write($"{print, 8}"); break;
        case 9:     Console.Write($"{print, 9}"); break;
        case 10:    Console.Write($"{print, 10}"); break;
        case 11:    Console.Write($"{print, 11}"); break;
        case 12:    Console.Write($"{print, 12}"); break;
        case 13:    Console.Write($"{print, 13}"); break;
        default:    Console.Write($"{print, 15}"); break;
    }
}

string ReplaceCommaWithDot(string str){
    string newStr = "";
    for(int i = 0; i < str.Length; i++){
        if(Convert.ToChar(str[i])==','){
            newStr += Convert.ToString('.');
        }
        else{
            newStr += Convert.ToString(str[i]);
        }
    }
    return newStr;
}

string GetValueFromMatrix(string[] coord, double [,]  matrix){
    string returnAnswer;
    int row;
    int col;
    row = Convert.ToInt32(coord[0]);
    col = Convert.ToInt32(coord[1]);
    if(row < matrix.GetLength(0) && col < matrix.GetLength(1)){
        returnAnswer = Convert.ToString(matrix[row, col]);
        return $"matrix[{row}, {col}] -> {returnAnswer}";
    }
    else{
        return $"matrix[{row}, {col}] -> There is no such elemet in matrix[{matrix.GetLength(0)}, {matrix.GetLength(1)}]";
    }
}
