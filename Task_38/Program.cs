// Задача №38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальными и минимальными элементами массива.

// [3 7 22 2 78] -> 76

Random rnd = new Random();
int size = rnd.Next(2, 11);
double[]   randomeMassive;
double     amplitude;
string  viewAnswer;

randomeMassive      = FillRandomeMassive(size, -100, 100, 3);
amplitude           = FindAmplitudeElementsOfMassive(randomeMassive, 3);
viewAnswer          = ShowAmpOfElements(randomeMassive, amplitude);
Console.WriteLine   ( viewAnswer );

double[] FillRandomeMassive(int size, int lowLimit, int highLimit, int accuracy){
    int amp = highLimit - lowLimit;
    double[] massive = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < massive.Length; i++){
        massive[i] = (rnd.NextDouble() * amp) +  lowLimit;
        massive[i] = Math.Round(massive[i], accuracy);
    }
    return massive;
}

double FindAmplitudeElementsOfMassive(double[] mssv, int accuracy){
    double min = mssv[0];
    double max = mssv[0];

    for(int i = 1; i < mssv.Length; i ++){
        if(mssv[i] < min){      min = mssv[i];}
        else{
            if(mssv[i] > max){  max = mssv[i];}
        }
    }

    return Math.Round(max - min, accuracy);
}

string ShowAmpOfElements(double[] massive, double amp){
    string viewMassive  = MakeViewStringMassive(massive);
    string viewResult   = "";

    string strAmp = Convert.ToString(amp);
    strAmp = ReplaceCommaWithDot(strAmp);
    viewResult         += $"The difference between the maximum and minimum elements is {strAmp}";
    return viewMassive + " -> " + viewResult;
}

string MakeViewStringMassive(double[] massive){
    string viewString = "[";
    int j = 1;
    for(int i = 0; i < massive.Length; i++, j++){
        viewString += Convert.ToString(massive[i]);
        if(j != massive.Length) viewString += "  ";
    }
    viewString += "]";
    viewString = ReplaceCommaWithDot(viewString);
    return viewString;
}

string ReplaceCommaWithDot(string str){
    string newStr = "";
    for(int i = 0; i < str.Length; i++){
        if(Convert.ToChar(str[i])==','){
            newStr += Convert.ToString('.');
        }
        else{
            if(Convert.ToChar(str[i])==' '){
                newStr += ",  ";    // Увеличил интервал для лучшей читабельности
                i++;
            }
            else{
                newStr += Convert.ToString(str[i]);
            }
            
        }
    }
    return newStr;
}

