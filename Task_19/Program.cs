// Задача №19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом

string strTestPalindrome = null;
Console.Write("Please, enter five character number: ");
strTestPalindrome = Console.ReadLine();
Console.Write   (
                    TestPalindrome(strTestPalindrome)
                );


string TestPalindrome(string strTestString){
    int i, j;
    j = strTestString.Length - 1;
    if(j != 4){
        // return "charecters must be just five, no more or less";
        Console.WriteLine("According to the condition of the Task, the entered characters must be five");
    }
    string strAnswer;
    bool bPalindrome;
    for(i = 0, bPalindrome = true; i < j; i++, j--){
        if( strTestString[i] != strTestString[j]){
            bPalindrome = false;
            break;
        }
    }
    strAnswer = strTestString + " -> ";
    strAnswer += bPalindrome ? "Yes, It's palindrome" : "No, it isn't palindrome";
    return strAnswer;
}
