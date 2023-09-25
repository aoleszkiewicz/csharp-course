namespace FirstLookAtDelegates;

public class Log
{
    public void LogTextToConsole(string text)
    {
        Console.WriteLine($"Date: {DateTime.Now} - {text}");
    }

    public void LogTextToFile(string text)
    {
        using StreamWriter streamWriter = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"), true);
        streamWriter.WriteLine($"Date: {DateTime.Now} - {text}");
    }
}