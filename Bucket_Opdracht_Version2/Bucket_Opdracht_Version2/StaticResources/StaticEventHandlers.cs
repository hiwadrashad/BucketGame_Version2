using Bucket_Opdracht_Version2.EventHandlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.StaticResources
{
    public static class StaticEventHandlers
    {
        public static BucketEventHandlers bucketEvent = new BucketEventHandlers();
        public static ContainerEventHandlers containerEvent = new ContainerEventHandlers();
        public static OilBarrelEventHandlers oilBarrelEvent = new OilBarrelEventHandlers();
        public static RainBarrelLargeEventHandlers RainBarrelLargeEvent = new RainBarrelLargeEventHandlers();
        public static RainBarrelMediumEventHandlers rainBarrelMediumEvent = new RainBarrelMediumEventHandlers();
        public static RainBarrelSmallEventhandlers rainBarrelSmallEvent = new RainBarrelSmallEventhandlers();
    }
}
