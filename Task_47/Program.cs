// Задача №47:
// Задайте двумерный массив размереом M x N,
// заполненный случайными вещественными числами

double [,] matrix;
int arrange     = 0;
int accuracy    = 3;
int min         = -1000;
int max         =  1000;

matrix          = FillMatrixRndDouble( 4, 6, min, max );
arrange         = GetMaxNumViewSignValue( matrix, accuracy );
PrintMatrixInt  ( matrix, arrange );

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
