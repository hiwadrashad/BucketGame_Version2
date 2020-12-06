using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.MainFunctions
{
    public static class RainbarrelMediumExecution
    {
        public static RainBarrelMediumModel generateMediumRainBarrel()
        {
            RainBarrelMediumModel mediumbarrel = new RainBarrelMediumModel();
            mediumbarrel.id = Guid.NewGuid().ToString();
            mediumbarrel.MaxCapacity = 120;
            mediumbarrel.CurrentContentValue = 120;
            return mediumbarrel;
        }
    }
}
