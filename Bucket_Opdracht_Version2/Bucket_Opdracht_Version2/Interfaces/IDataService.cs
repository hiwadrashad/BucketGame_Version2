using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.Interfaces
{
    interface IDataService
    {
        public bool AddContainer();
        public bool AddBucketToContainer(BucketModel bucket);

        public bool AddOilBarrelToContainer(OilBarrelModel oilbarrel);
        public bool AddMediumRainBarrelToContainer(RainBarrelMediumModel mediumbarrel);
        public bool AddSmallRainBarrelToContainer(RainbarrelSmallModel smallbarrel);
        public bool AddLargeRainBarrelToContainer(RainBarrelLargeModel largeModel);
        public bool emptyBucket(BucketModel bucket);
        public bool emptyOilBarrel(OilBarrelModel oil);
        public bool emptyMediumRainBarrel(RainBarrelMediumModel mediumbarrel);
        public bool emptySmallMediumRainBarrel(RainbarrelSmallModel smallmodel);
        public bool emptyLargeRainBarrel(RainBarrelLargeModel largemodel);
        public bool FillBucket(BucketModel bucket);
        public bool FillOilBarrel(OilBarrelModel oil);
        public bool FillMediumRainBarrel(RainBarrelMediumModel mediumbarrel);
        public bool FillSmallMediumRainBarrel(RainbarrelSmallModel smallmodel);
        public bool FillLargeRainBarrel(RainBarrelLargeModel largemodel);
#nullable enable
        public ContainerModel? chooseContainer();
#nullable disable
#nullable enable
        public BucketModel? chooseBucket();
#nullable disable
#nullable enable
        public OilBarrelModel? chooseOilBarrel();
#nullable disable
#nullable enable
        public RainbarrelSmallModel? chooseSmallBarrel();
#nullable disable
#nullable enable
        public RainBarrelMediumModel? chooseMediumBarrel();
#nullable disable
#nullable enable
        public RainBarrelLargeModel? chooseLargeBarrel();
#nullable disable

    }
}

