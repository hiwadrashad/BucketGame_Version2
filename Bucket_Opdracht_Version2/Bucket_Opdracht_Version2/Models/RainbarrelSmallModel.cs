using Bucket_Opdracht_Version2.ModelStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.Models
{
    public class RainbarrelSmallModel : FillingUnitsAbstractStructure
    {
        private string _id;

        private int _maxCapacity;

        private int _currentContentValue;
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
    }
}
