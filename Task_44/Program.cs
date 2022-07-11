// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] firstTwoSighnFibo = new int[] {0, 1};
int[] ourRange;
int   sizeRange;
string answer;

Console.Write               ( "Enter the desired length of the array to generate the Fibonacci series: " );
sizeRange = int.Parse       ( Console.ReadLine() );
if(sizeRange < 0){            sizeRange = 0 - sizeRange; }
if(sizeRange == 0)            sizeRange = 1;
ourRange                    = new int[sizeRange];
CopyMassive                 ( ourRange, firstTwoSighnFibo, 0, 0, 2 );
MakeFibonacciRange          ( ourRange );
answer = ShowFibonacciRange ( ourRange );
Console.WriteLine           ( answer );

void MakeFibonacciRange(int[] mssv){
    int first   = 0;
    int second  = 1;
    int current = 2;
    for( ;current < mssv.Length; first++, second++, current++){
        mssv[current] = mssv[first] + mssv[second];
    }
}

void CopyMassive(int[] receive, int[] transmit, int strtRcv, int strtTrmt, int length){
    if((receive.Length - strtRcv) < length || (transmit.Length - strtTrmt) < length){  return;}
    for(int i = 0; i < length; i++){
        receive[strtRcv++] = transmit[strtTrmt++];
    }
}

string ShowFibonacciRange(int[] mssv){
    string viewMassive = MakeViewStringMassive(mssv);
    string viewResult  = $"Fibonacci series of {mssv.Length} elements";

    return viewResult + " -> " + viewMassive;
}

string MakeViewStringMassive(int[] massive){
    string viewString = /*"["*/ "";
    int j = 1;
    for(int i = 0; i < massive.Length; i++, j++){
        viewString += Convert.ToString(massive[i]);
        if(j != massive.Length) viewString += ", ";
    }
    /*viewString += "]";*/
    return viewString;
}
