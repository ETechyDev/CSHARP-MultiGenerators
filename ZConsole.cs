public static class ZConsole
{
    private const int Delay = 750;

    public static void WriteLine(string output)
    {
        Thread.Sleep(Delay);
        Console.WriteLine(output);
    }

    public static void Write(string output)
    {
        Thread.Sleep(Delay);
        Console.Write(output);
    }

    public static string ReadLine()
    {
        Thread.Sleep(Delay);
        return Console.ReadLine();
    }

    public static int Read()
    {
        Thread.Sleep(Delay);
        return Console.Read();
    }

}