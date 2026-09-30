using AutoPong;

internal static class Program
{
    private static void Main()
    {
        // The game is laid out for a 1280x720 back buffer.
        Rxdk.Display.MaxHeight = 720;
        using (var game = new AutoPongGame())
            game.Run();
    }
}
