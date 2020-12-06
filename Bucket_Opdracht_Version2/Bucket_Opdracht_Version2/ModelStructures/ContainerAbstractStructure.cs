using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.ModelStructures
{
    public abstract class ContainerAbstractionStructure
    {
        #region
        public abstract string id { get; set; }

        public abstract int MaxCapacity { get; set; }

        public abstract int CurrentContentValue { get; set; }

        public virtual int currentContainer { get; set; }

        public static List<ContainerModel> containers { get; set; }

        public abstract List<BucketModel> BucketsStoredInsideThisContainer { get; set; }

        public abstract List<OilBarrelModel> OilBarrelsStoredInsideThisContainer { get; set; }

        public abstract List<RainbarrelSmallModel> SmallRainBarrelsStoredInsideThisContainer { get; set; }

        public abstract List<RainBarrelMediumModel> MediumRainBarrelsStoredInsideThisContainer { get; set; }

        public abstract List<RainBarrelLargeModel> LargeRainBarrelsStoredInsideThisContainer { get; set; }

        //public virtual void AddValue(OilBarrelModel oil)
        //{
        //    if (CurrentContentValue > MaxCapacity)
        //    {
        //        Console.WriteLine("Container is full");
        //    }
        //    if (CurrentContentValue == MaxCapacity)
        //    {
        //        Console.WriteLine("Container is full choosing another container");
        //        ContainerModel newmodel = new ContainerModel()
        //        {
        //            id = Guid.NewGuid().ToString(),
        //            curr
        //        }
                
        //        currentContainer = AmountofContainers;
        //    }
        //    if (CurrentContentValue < MaxCapacity)
        //    {
        //        MaxCapacity += oil.MaxCapacity;
        //    }
        //}

        //public virtual void AddValue(RainbarrelSmallModel rainbarrelsmall)
        //{
        //    if (CurrentContentValue > MaxCapacity)
        //    {
        //        Console.WriteLine("Container broke removing Container");
        //        AmountofContainers = AmountofContainers - 1;
        //        currentContainer = currentContainer - 1;
        //    }
        //    if (CurrentContentValue == MaxCapacity)
        //    {
        //        Console.WriteLine("Container is full chosing another container");
        //        AmountofContainers = AmountofContainers + 1;
        //        currentContainer = AmountofContainers;
        //    }
        //    if (CurrentContentValue < MaxCapacity)
        //    {
        //        MaxCapacity += rainbarrelsmall.MaxCapacity;
        //    }
        //}

        //public virtual void AddValue(RainBarrelMediumModel rainBarrelMedium)
        //{
        //    if (CurrentContentValue > MaxCapacity)
        //    {
        //        Console.WriteLine("Container broke removing Container");
        //        AmountofContainers = AmountofContainers - 1;
        //        currentContainer = currentContainer - 1;
        //    }
        //    if (CurrentContentValue == MaxCapacity)
        //    {
        //        Console.WriteLine("Container is full chosing another container");
        //        AmountofContainers = AmountofContainers + 1;
        //        currentContainer = AmountofContainers;
        //    }
        //    if (CurrentContentValue < MaxCapacity)
        //    {
        //        MaxCapacity += rainBarrelMedium.MaxCapacity;
        //    }
        //}

        //public virtual void AddValue(RainBarrelLargeModel rainBarrelLarge)
        //{
        //    if (CurrentContentValue > MaxCapacity)
        //    {
        //        Console.WriteLine("Container broke removing Container");
        //        AmountofContainers = AmountofContainers - 1;
        //        currentContainer = currentContainer - 1;
        //    }
        //    if (CurrentContentValue == MaxCapacity)
        //    {
        //        Console.WriteLine("Container is full chosing another container");
        //        AmountofContainers = AmountofContainers + 1;
        //        currentContainer = AmountofContainers;
        //    }
        //    if (CurrentContentValue < MaxCapacity)
        //    {
        //        MaxCapacity += rainBarrelLarge.MaxCapacity;
        //    }
        //}


        //public virtual void AddValue(BucketModel rainBarrelLarge)
        //{
        //    if (CurrentContentValue > MaxCapacity)
        //    {
        //        Console.WriteLine("Container broke removing Container");
        //        AmountofContainers = AmountofContainers - 1;
        //        currentContainer = currentContainer - 1;
        //    }
        //    if (CurrentContentValue == MaxCapacity)
        //    {
        //        Console.WriteLine("Container is full chosing another container");
        //        AmountofContainers = AmountofContainers + 1;
        //        currentContainer = AmountofContainers;
        //    }
        //    if (CurrentContentValue < MaxCapacity)
        //    {
        //        MaxCapacity += rainBarrelLarge.MaxCapacity;
        //    }
        //}

        //public virtual void RemoveValue(BucketModel )
        //{ 
        
        //}






        #endregion

        public ContainerAbstractionStructure()
        {
            id = Guid.NewGuid().ToString();
        }
    }
}
