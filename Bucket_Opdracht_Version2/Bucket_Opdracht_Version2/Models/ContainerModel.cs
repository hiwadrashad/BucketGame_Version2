using Bucket_Opdracht_Version2.ModelStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.Models
{
    public class ContainerModel : ContainerAbstractionStructure
    {
        private string _id;

        private int _maxCapacity;

        private int _currentContentValue;

        private List<BucketModel> _BucketsStoredInsideThisContainer;
        
        private List<OilBarrelModel> _OilBarrelsStoredInsideThisContainer;

        private List<RainbarrelSmallModel> _SmallRainBarrelsStoredInsideThisContainer;

        private List<RainBarrelMediumModel> _MediumRainBarrelsStoredInsideThisContainer;

        private List<RainBarrelLargeModel> _LargeRainBarrelsStoredInsideThisContainer;



        //private int _currentContainer;

        public override string id 
        { 
            get => 
                _id; 
            set => 
                _id = value;
        }
        public override int MaxCapacity 
        { 
            get => 
                _maxCapacity; 
            set => 
                _maxCapacity = value;
        }
        public override int CurrentContentValue 
        { 
            get => 
                _currentContentValue;
            set => 
                _currentContentValue = value;
        }
        public override List<BucketModel> BucketsStoredInsideThisContainer 
        { 
            get => 
                _BucketsStoredInsideThisContainer; 
            set => 
                _BucketsStoredInsideThisContainer = value;
        }
        public override List<OilBarrelModel> OilBarrelsStoredInsideThisContainer
        {
            get =>
                _OilBarrelsStoredInsideThisContainer;
            set =>
                _OilBarrelsStoredInsideThisContainer = value;
        }
        public override List<RainbarrelSmallModel> SmallRainBarrelsStoredInsideThisContainer
        {
            get =>
                _SmallRainBarrelsStoredInsideThisContainer;
            set =>
                _SmallRainBarrelsStoredInsideThisContainer = value;
        }
        public override List<RainBarrelMediumModel> MediumRainBarrelsStoredInsideThisContainer
        {
            get =>
                _MediumRainBarrelsStoredInsideThisContainer;
            set =>
                _MediumRainBarrelsStoredInsideThisContainer = value;
        }
        public override List<RainBarrelLargeModel> LargeRainBarrelsStoredInsideThisContainer
        {
            get =>
                _LargeRainBarrelsStoredInsideThisContainer;
            set =>
                _LargeRainBarrelsStoredInsideThisContainer = value;
        }
    }
}
