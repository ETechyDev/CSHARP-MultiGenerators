public static class ZRand
{
    public static int GetLimitedRandom(int min, int max)
    {
        int x = new Random().Next(max);
        while (x < min)
        {
            x = new Random().Next(max);
        }
        return x;
    }

    public static char GetRandomSymbol()
    {
        return GetRandomChar(GenerationData.symbols);
    }

    public static char GetRandomLetter()
    {
        return GetRandomChar(GenerationData.letters);
    }

    public static string GetRandomDigit()
    {
        return (new Random().Next(9)).ToString();
    }

    public static string GetMixedRandomPassword(int length)
    {
        string pw = string.Empty;
        for(int i = 0; i < length; i++)
        {
            int y = GetLimitedRandom(0, 3);

            if (y == 1)
                pw += GetRandomDigit();
            else if (y == 2)
                pw += GetRandomSymbol();
            else if (y == 3)
                pw += GetRandomLetter();
        }
        return pw;
    }
    public static char GetRandomChar(char[] table)
    {
        int length = table.Length - 1;
        int RandomIndex = new Random().Next(length);
        return table[RandomIndex];
    }
}