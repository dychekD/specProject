string [] ThreeSymbols (string [] arrayInitial)
{
    string [] temp = new string [arrayInitial.Length];
    int count = 0;
    for (int i = 0; i < arrayInitial.Length; i++)
    {
        if (arrayInitial [i].Length <= 3) 
        {
            temp [count] = arrayInitial [i];
            count++;
        }
    }
    if (count == 0) 
    {
        string[] empty = new string [1];
        return empty;
    }
    else if (count==arrayInitial.Length) return temp;
    else
    {
        string [] result = new string [count];
        for (int j = 0; j < count; j++) result [j] = temp [j];
        return result;
    }
}

void PrintArray (string [] arrayIn)
{
    if (arrayIn [0]==string.Empty && arrayIn.Length == 1) Console.WriteLine ("[]");
    else if (arrayIn.Length==1 && arrayIn [0] != string.Empty) Console.WriteLine ($"[{arrayIn [0]}]");
    else 
    {
        Console.Write ($"[{arrayIn [0]}, ");
        for (int i = 1; i < arrayIn.Length-1; i++) Console.Write ($"{arrayIn [i]}, ");
        Console.WriteLine ($"{arrayIn [arrayIn.Length -1]}]");
    }
}

string [] newAr = {"new", "12345", "sun", "dog", ")", "no"};
string [] newAr2 = {"134567", "12345"};
string [] newAr3 = {"134567", "12345", ")"};
PrintArray (newAr3);
PrintArray (ThreeSymbols (newAr3));