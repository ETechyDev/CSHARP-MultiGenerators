public static class ErrorHandler
{
    public static bool CheckConversionValidation(string len)
    {
        bool IsValid = true;
        char[] chars = len.ToCharArray();
        
        for (int i = 0; i < chars.Length; i++)
        {
            if (!GenerationData.digits.Contains(chars[i]))
            {
                Console.WriteLine("Invalid password length!");
                IsValid = false;
                break;
            }
        }
        return IsValid;
    }
}