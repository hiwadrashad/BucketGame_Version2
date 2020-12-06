using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.MainFunctions
{
    public static class RainBarrelLargeExecution
    {
        public static RainBarrelLargeModel GenerateLargeRainBarrel()
        {
            RainBarrelLargeModel largebarrel = new RainBarrelLargeModel();
            largebarrel.id = Guid.NewGuid().ToString();
            largebarrel.MaxCapacity = 160;
            largebarrel.CurrentContentValue = 160;
            return largebarrel;
        }
    }
}
