using NeonShooter;

internal static class Program
{
    private static void Main()
    {
        // The grid and particle fill rate does not keep up at 1080i.
        Rxdk.Display.MaxHeight = 720;
        using (var game = new NeonShooterGame())
            game.Run();
    }
}
