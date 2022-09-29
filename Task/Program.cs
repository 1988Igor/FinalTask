void FillArrray(string[] str)
{
    for (int i = 0; i < str.Length; i++)

        str[i] = Console.ReadLine() ?? "0";
}
