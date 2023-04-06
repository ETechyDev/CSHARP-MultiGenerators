public static class IO
{
    public static int GetPWLen()
    {
        ZConsole.Write("Password Length: ");
        string len = ZConsole.ReadLine();

        while (!ErrorHandler.CheckConversionValidation(len))
        {
            ZConsole.Write("Password Length: ");
            len = ZConsole.ReadLine();
        }

        return Convert.ToInt16(len);
    }
}