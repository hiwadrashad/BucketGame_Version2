using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.MainFunctions
{
    public static class RainBarrelSmallExecution
    {
        public static RainbarrelSmallModel generateSmallRainbarrel()
        {
            RainbarrelSmallModel smallbarrel = new RainbarrelSmallModel();
            smallbarrel.id = Guid.NewGuid().ToString();
            smallbarrel.CurrentContentValue = 80;
            smallbarrel.MaxCapacity = 80;
            return smallbarrel;
        }
    }
}
