// Задача 52: 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

string      answer;
int row         = 3;
int col         = 7;
int arrange     = 0;
int accuracy    = 2;
int min         = -1000;
int max         =  1000;

int [,] matrix;

matrix              = FillMatrixRndInt(row, col, min, max);
arrange             = GetMaxNumViewSignValue(matrix, accuracy);
PrintMatrixInt      ( matrix, arrange);   
answer              = CountAverageColumns(matrix, accuracy, arrange);
Console.WriteLine   ( "Arithmetic mean in each column:");
Console.WriteLine   ( answer );

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

string CountAverageColumns(int[,] mtrx, int accuracy,int arrange){
    string  averages = " ";
    string  strOneAverage;
    int     sumColumn;
    double  average;
    for(int i = 0; i < mtrx.GetLength(1); i++){
        sumColumn = 0;
        for(int j = 0; j < mtrx.GetLength(0); j++){
            sumColumn += mtrx[j,i];
        }
        average = (double)sumColumn / (double)mtrx.GetLength(0);
        average = Math.Round(average, accuracy);
        strOneAverage = Convert.ToString(average);
        strOneAverage = ReplaceCommaWithDot(strOneAverage);
        averages += StringArrange(strOneAverage, arrange);
        //if(i < mtrx.GetLength(1) - 1){averages += " ";}
    }
    return averages;
}

string StringArrange(string str, int arrange){
    string stringArrange = "";
    if(str.Length < arrange){
        for(int i = 0; i < arrange - str.Length; i++){
            stringArrange += " ";
        }
    }
    return stringArrange + str;
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
