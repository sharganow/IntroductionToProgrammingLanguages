// Задача №57:
// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

int row         = 3;
int col         = 7;
int arrange     = 0;
int accuracy    = 2;
int min         = -1;
int max         =  5;

int [,] matrix;
int[,]  valuesAndFraquencys;

matrix              = FillMatrixRndInt       ( row, col, min, max );
arrange             = GetMaxNumViewSignValue ( matrix, accuracy );
valuesAndFraquencys = MakeValueFraqMassive   ( matrix );

PrintMatrixInt      ( matrix, arrange);
Console.WriteLine   ( "for this matrix, the frequency array is as follows: ");
PrintValAndFraq     ( valuesAndFraquencys, arrange);

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

int[,] MakeValueFraqMassive(int[,] mssv){
    int[,] vAf = new int[2,1]  {{mssv[0,0]},{0}};
    for(int i = 0; i < mssv.GetLength(0); i++){
        for(int j = 0; j < mssv.GetLength(1); j++){
            vAf = availabilityСheck(vAf, mssv[i,j]);
        }   
    }
    return vAf;
}

int[,] availabilityСheck(int[,] vAf, int checkValue){
    for(int i = 0; i < vAf.GetLength(1); i++){
        if(vAf[0,i] > checkValue){
            vAf = addVaF(vAf, checkValue, i);
            return vAf;
        }
        else{
            if(vAf[0,i] == checkValue){
                vAf[1,i]++;
                return vAf;
            }
        }
    }
    vAf = addVaF(vAf, checkValue, vAf.GetLength(1));
    return vAf;
}

int[,] addVaF(int[,] vAf, int newValue, int posNewValue){
    int[,] newVaF = new int[2, vAf.GetLength(1)+1];
    CopyFragmetVaf(newVaF, vAf, 0, 0,  posNewValue);
    newVaF[0, posNewValue] = newValue;
    newVaF[1, posNewValue] = 1;
    CopyFragmetVaf(newVaF, vAf, posNewValue + 1, posNewValue,  vAf.GetLength(1) - posNewValue);
    return newVaF;
}

void CopyFragmetVaf(int[,] cpMssv, int[,] orgn, int iRecipient, int iSource,  int length){
    for(int i = 0; i < length; i++){
        cpMssv[0, iRecipient]   = orgn[0, iSource];
        cpMssv[1, iRecipient++] = orgn[1, iSource++];
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

void PrintValAndFraq(int[,] vAf, int arrange){
    String strPprint; 
    for(int j = 0; j < vAf.GetLength(1); j++){
        strPprint = Convert.ToString(vAf[0,j]);
        ConsoleWriteArrange(strPprint, arrange);
        Console.Write("  appears");
        strPprint = Convert.ToString(vAf[1,j]);
        ConsoleWriteArrange(strPprint, 4);
        WriteWordTimes(vAf[1,j]);
        Console.WriteLine("");
    }    
}

void WriteWordTimes(int times){
    switch(times){
        case 0:     
        case 1:     Console.Write(" time");  break;    //раз
        case 2:     
        case 3:     
        case 4:     Console.Write(" times"); break;  //раза
        default:    Console.Write(" time");  break;
    }
}
