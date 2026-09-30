using FuelCell;

internal static class Program
{
    private static void Main()
    {
        using (var game = new FuelCellGame())
            game.Run();
    }
}
