using System;

namespace GameAdapterPattern
{
    public class VideoGame
    {
        private string title;
        private AgeRating ageRating;
        private double budgetInMillions;
        private int requiredGpuMemoryMB;
        private int requiredDiskSpaceGB;
        private int requiredRamGB;
        private int requiredCores;
        private double requiredCoreSpeedGHz;
        private int gpuMemoryInMB;
        private int requiredDiskSpaceInGB;
        private int requiredRAMInGB;
        private double coreSpeedInGHz;

        public VideoGame(string title,
                         AgeRating ageRating,
                         double budgetInMillions,
                         int requiredGpuMemoryMB,
                         int requiredDiskSpaceGB,
                         int requiredRamGB,
                         int requiredCores,
                         double requiredCoreSpeedGHz,
                         int gpuMemoryInMB,
                         int requiredDiskSpaceInGB,
                         int requiredRAMInGB,
                         double coreSpeedInGHz)
        {
            this.title = title;
            this.ageRating = ageRating;
            this.budgetInMillions = budgetInMillions;
            this.requiredGpuMemoryMB = requiredGpuMemoryMB;
            this.requiredDiskSpaceGB = requiredDiskSpaceGB;
            this.requiredRamGB = requiredRamGB;
            this.requiredCores = requiredCores;
            this.requiredCoreSpeedGHz = requiredCoreSpeedGHz;
        }

        public VideoGame(string title, AgeRating ageRating, int budgetInMillions, int gpuMemoryInMB, int requiredDiskSpaceInGB, int requiredRAMInGB, int requiredCores, double coreSpeedInGHz)
        {
            this.title = title;
            this.ageRating = ageRating;
            this.budgetInMillions = budgetInMillions;
            this.gpuMemoryInMB = gpuMemoryInMB;
            this.requiredDiskSpaceInGB = requiredDiskSpaceInGB;
            this.requiredRAMInGB = requiredRAMInGB;
            this.requiredCores = requiredCores;
            this.coreSpeedInGHz = coreSpeedInGHz;
        }

        public string GetTitle()
        {
            return title;
        }

        public AgeRating GetAgeRating()
        {
            return ageRating;
        }

        public double GetBudget()
        {
            return budgetInMillions;
        }

        public int GetRequiredGpuMemory()
        {
            return requiredGpuMemoryMB;
        }

        public int GetRequiredDiskSpace()
        {
            return requiredDiskSpaceGB;
        }

        public int GetRequiredRam()
        {
            return requiredRamGB;
        }

        public int GetRequiredCores()
        {
            return requiredCores;
        }

        public double GetRequiredCoreSpeed()
        {
            return requiredCoreSpeedGHz;
        }
    }

    public enum AgeRating
    {
        P3, P7, P12, P16, P18
    }
}
