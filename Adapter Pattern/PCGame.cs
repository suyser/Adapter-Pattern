using System;

namespace GameAdapterPattern
{
    public interface IGame
    {
        string RetrieveTitle();
        int RetrieveAgeRating();
        bool IsHighBudgetGame();
        GameRequirements FetchRequirements();
    }

    public class GameAdapter : IGame
    {
        private VideoGame videoGame;

        public GameAdapter(VideoGame videoGame)
        {
            this.videoGame = videoGame;
        }

        public string RetrieveTitle()
        {
            return videoGame.GetTitle();
        }



        public int RetrieveAgeRating()
        {
            switch (videoGame.GetAgeRating())
            {
                case AgeRating.P3:
                    return 3;
                case AgeRating.P7:
                    return 7;
                case AgeRating.P12:
                    return 12;
                case AgeRating.P16:
                    return 16;
                case AgeRating.P18:
                    return 18;
                default:
                    return 0;
            }
        }

        public bool IsHighBudgetGame()
        {
            return videoGame.GetBudget() > 50.0;
        }

        public GameRequirements FetchRequirements()
        {
            int gpuMemoryInGB = (int)Math.Ceiling((double)videoGame.GetRequiredGpuMemory() / 1024);
            return new GameRequirements(
                gpuMemoryInGB,
                videoGame.GetRequiredDiskSpace(),
                videoGame.GetRequiredRam(),
                videoGame.GetRequiredCoreSpeed(),
                videoGame.GetRequiredCores()
            );
        }
    }

    public class GameRequirements
    {
        public int GpuMemory { get; }
        public int DiskSpace { get; }
        public int Ram { get; }
        public double CoreSpeed { get; }
        public int Cores { get; }

        public GameRequirements(int gpuMemory, int diskSpace, int ram, double coreSpeed, int cores)
        {
            GpuMemory = gpuMemory;
            DiskSpace = diskSpace;
            Ram = ram;
            CoreSpeed = coreSpeed;
            Cores = cores;
        }
    }
}
