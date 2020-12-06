using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bucket_Opdracht_Version2.ModelStructures
{
    public abstract class FillingUnitsAbstractStructure
    {
        #region
        [Key]
        public abstract string id { get; set; }

        public abstract int MaxCapacity {get;set;}

        public abstract int CurrentContentValue { get; set; }

        #endregion

        #region 
        public FillingUnitsAbstractStructure()
        {
            id = Guid.NewGuid().ToString();
        }
        #endregion
    }
}
