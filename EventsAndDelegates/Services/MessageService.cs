namespace EventsAndDelegates;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs videoEventArgs)
    {
        Console.WriteLine("MessageService: Sending a text message..." + videoEventArgs.Video.Title);
    }
}