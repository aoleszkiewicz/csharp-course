namespace EventsAndDelegates;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs videoEventArgs)
    {
        Console.WriteLine("MailService: Sending an email..." + videoEventArgs.Video.Title);
    }
}