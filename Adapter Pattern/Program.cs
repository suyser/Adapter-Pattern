using GameAdapterPattern;

internal class GameProgram
{
    private static void Main(string[] args)
    {
        VideoGame newGame = new VideoGame(
            title: "ByByByBeBeBe",
            ageRating: AgeRating.P7,
            budgetInMillions: 1,
            gpuMemoryInMB: 10,
            requiredDiskSpaceInGB: 1,
            requiredRAMInGB: 1,
            requiredCores: 1,
            coreSpeedInGHz: 2.4
        );

        GameAdapter gameAdapter = new GameAdapter(newGame);

        Console.WriteLine(gameAdapter.RetrieveTitle());
        Console.WriteLine(gameAdapter.RetrieveAgeRating());
        Console.WriteLine(gameAdapter.FetchRequirements().ToString());

        if (gameAdapter.IsHighBudgetGame())
        {
            Console.WriteLine("High Budget Game");
        }
        else
        {
            Console.WriteLine("Not a High Budget Game");
        }
    }
}
