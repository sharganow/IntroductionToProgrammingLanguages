// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


bool bIntersection;     int line;
bool bEqualityСheck;
int k1;     int b1;
int k2;     int b2;
double[] intersectionPoint  = new double[2];    /* Здесь объявлена и создана заготовка массива,
                                                    хранящего координаты точки пересечения заданных прямых
                                                    нулевой индекс - значение координаты Х
                                                    первый индекс  - значение координаты Y */
double deviation;
string answer;
Console.Write("Set the value of the coefficient K1: ");
k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Set the value of the coefficient B1: ");
b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Set the value of the coefficient K2: ");
k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Set the value of the coefficient B2: ");
b2 = Convert.ToInt32(Console.ReadLine());
bIntersection       = false;
bEqualityСheck      = false;
deviation           = 0.00001;
line                = 0;

if(k1 == k2){
    if(b1 == b2){
        Console.WriteLine("You defined the parameters of the same line twice");
    }
    else{
        Console.WriteLine("The lines to be checked are parallel and do not intersect.");
    }
}
else{
    if(
        FindYintersectionPoint(intersectionPoint, k1, b1, k2, b2)
    ){
        if(
            FindXintersectionPoint(intersectionPoint, k1, b1)
        ){
            double tempX = intersectionPoint[0];
            if(
                FindXintersectionPoint(intersectionPoint, k2, b2)
            ){
                bEqualityСheck = EqualityСheck(tempX, intersectionPoint[0], deviation);
            }
            else{
                bIntersection = true;
                line          = 2;
            }
        }
        else{
            if(
                FindXintersectionPoint(intersectionPoint, k2, b2)
            ){
                bIntersection = true;
                line          = 1;
            }
            else{
                Console.WriteLine("Lines are either parallel or united");
            }
        }
    }
    else{
        Console.WriteLine("Lines are either parallel or united");
    }
}

if(bIntersection){
    bEqualityСheck                  = true;
    Console.WriteLine               ( $"Line{line} parallel to X axis" );
}

if(bEqualityСheck){
    RoundTheValuesOfArrayElements   ( intersectionPoint, 3 );
    answer                          = ShowPointOfIntersectionForGivenStraightLines(intersectionPoint, k1, b1, k2, b2);
    answer                          = CorrectPlusSign(answer);
    Console.WriteLine               ( answer );
}

bool FindYintersectionPoint(double[] iP, int k1, int b1, int k2, int b2){
    int dividend;
    int divider;
    divider = k2 - k1;
    if(divider == 0){
        return false;
    }
    else{
        dividend = (b1*k2) - (b2*k1);
        iP[1] = (double) dividend / (double) divider;
        return true;
    }
}

bool FindXintersectionPoint(double[] iP, int k, int b){
    double dividend;
    if(k == 0){
        return false;
    }
    else{
        dividend = iP[1] - (double) b;
        iP[0] = dividend / (double) k;
        return true;
    }
}

bool EqualityСheck(double var1, double var2, double deviation){
    if(var1 == var2){
        return true;
    }
    else{
        if(var1 > var2){
            double  temp = var2;
                    var2 = var1;
                    var1 = temp;
        }
        if( var2 - var1 <= deviation){
            return true;
        }
        else{
            return false;
        }
    }
}

string ShowPointOfIntersectionForGivenStraightLines(double[] iP, int k1, int b1, int k2, int b2){
    string sTerms;
    string sIntersection;
    sTerms          = $"Intersection point for lines: y={k1}x+{b1} and y={k2}x+{b2} -> ";
    sIntersection   = MakeViewStringMassive(iP);
    return sTerms + sIntersection;
}

void RoundTheValuesOfArrayElements(double[] iP, int accuracy){
    for(int i = 0; i < iP.Length; i++){
        iP[i] = Math.Round(iP[i], accuracy);
    }
}

string MakeViewStringMassive(double[] massive){
    string viewString = "(";
    int j = 1;
    for(int i = 0; i < massive.Length; i++, j++){
        viewString += Convert.ToString(massive[i]);
        if(j != massive.Length) viewString += "; ";
    }
    viewString += ")";
    return viewString;
}

string CorrectPlusSign(string str){
    string newStr = "";
    for(int i = 0; i < str.Length; i++){
        if(Convert.ToChar(str[i])=='+'){
            int j = i + 1;
            if(j < str.Length){
                if(Convert.ToChar(str[j])!='-'){
                    newStr += Convert.ToString(str[i]);
                }
            }
        }
        else{
            newStr += Convert.ToString(str[i]);
        }
    }
    return newStr;
}
