// Задача №60:
// Сформируйте трехмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int row         = 3;
int col         = 2;
int hig         = 4;
int arrange     = 0;
int min         = -99;
int max         =  99;

int [,,] matrix;

matrix              = FillMatrixRndInt          ( row, col, hig, min, max );
arrange             = GetMaxNumViewSignValue    ( matrix );
                      PrintMatrixInt            ( matrix, arrange );

int[,,] FillMatrixRndInt(int row, int col, int hig, int min, int max){
    int[,,] mssv = new int[row, col, hig];
    int[] allVallues = new int[max - min];
    int iAllVallues = -1;
    Random rnd = new Random();
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            for(int h = 0; h < mssv.GetLength(2); h++){
                int seak = iAllVallues;
                do{
                    int value = rnd.Next( min, max + 1 );
                    if(!IsThereValue(allVallues, iAllVallues, value)){
                        mssv[i,j,h] = value;
                        iAllVallues++;
                        if(iAllVallues < allVallues.Length){
                            allVallues[iAllVallues] = value;
                        }                    
                        seak = allVallues.Length;
                    }
                    else{
                        if(iAllVallues == allVallues.Length){
                            mssv[i,j,h] = max;    // массив всёравно заполнить нужно, плюс мы отразим переполнение значений
                        }
                    }                
                }while(seak < allVallues.Length);
            }
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

int GetMaxNumViewSignValue(int[,,] mtrx){
    int maxNum = 1;
    int seak;
    for(int i = 0; i < mtrx.GetLength(0); i++){
        for(int j = 0; j < mtrx.GetLength(1); j++){
            for(int h = 0; h < mtrx.GetLength(2); h++){
                seak = GetNumViewSignValue(mtrx[i,j,h]);
                maxNum = seak > maxNum ? seak : maxNum;
            }
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

void PrintMatrixInt(int[,,] mssv, int arrange){
    String strPprint;
    int numValString = 0;
    ConsoleWriteArrange("[", 1);
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            for(int h = 0; h < mssv.GetLength(2); h++){
                    numValString++;
                    strPprint = Convert.ToString(mssv[i,j,h]) + 
                                $" (x:{i} y:{j} z:{h})";
                    ConsoleWriteArrange(strPprint, arrange + 16);
                    //if(h < (mssv.GetLength(2) -1)){   Console.Write(",");}
                    if(numValString > 4){
                        numValString = 0;
                        Console.WriteLine("");
                        ConsoleWriteArrange(" ", 1);
                    } 
            }
        }
    }
    ConsoleWriteArrange("]", arrange - 2);
    Console.WriteLine("");
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
        case 14:    Console.Write($"{print, 14}"); break;
        case 15:    Console.Write($"{print, 15}"); break;
        case 16:    Console.Write($"{print, 16}"); break;
        case 17:    Console.Write($"{print, 17}"); break;
        case 18:    Console.Write($"{print, 18}"); break;
        case 19:    Console.Write($"{print, 19}"); break;
        case 20:    Console.Write($"{print, 20}"); break;
        case 21:    Console.Write($"{print, 21}"); break;
        case 22:    Console.Write($"{print, 22}"); break;
        case 23:    Console.Write($"{print, 23}"); break;
        case 24:    Console.Write($"{print, 24}"); break;
        case 25:    Console.Write($"{print, 25}"); break;
        case 26:    Console.Write($"{print, 26}"); break;
        default:    Console.Write($"{print, 27}"); break;
    }
}
