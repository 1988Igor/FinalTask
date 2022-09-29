void FillArrray(string[] str)
{
    for (int i = 0; i < str.Length; i++)

        str[i] = Console.ReadLine() ?? "0";
}
void PrintArrray1(string[] str)
{
    foreach (string i in str)
    {
        Console.Write(" " + i);
    }
    Console.WriteLine();
}
void PrintArrray2(string[] str, string[] str2)
{
    for (int i = 0; i < str.Length - 2; i++)
    {
        str2[i] = str[i];
        Console.Write(" " + str2[i]);
    }

}

string[] str = new string[4];
string[] str2 = new string[2];
Console.WriteLine("Enter the elements of array :");
FillArrray(str);
Console.WriteLine("The first array :");
PrintArrray1(str);
Console.WriteLine("The changed array :");
PrintArrray2(str, str2);