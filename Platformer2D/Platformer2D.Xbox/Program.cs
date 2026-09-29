using Platformer2D;

internal static class Program
{
    private static void Main()
    {
        using (var game = new PlatformerGame())
            game.Run();
    }
}
