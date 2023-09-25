namespace FirstLookAtDelegates;


public static class Program
{
    private delegate void LogDelegate(string text);
    
    public static void Main(string[] args)
    {
        var log = new Log();

        var logTextToConsoleDel = new LogDelegate(log.LogTextToConsole);
        var logTextToFileDel = new LogDelegate(log.LogTextToFile);
        
        var multiLogDel = logTextToConsoleDel + logTextToFileDel;
        
        Console.WriteLine("Please enter your name:");
        var name = Console.ReadLine();

        if (name != null) LogText(multiLogDel, name);
    }

    private static void LogText(LogDelegate logDelegate, string text)
    {
        logDelegate(text);
    }
}