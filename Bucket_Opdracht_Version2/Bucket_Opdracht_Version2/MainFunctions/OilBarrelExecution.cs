using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.MainFunctions
{
    public static class OilBarrelExecution
    {
        public static OilBarrelModel GenerateOilBarrel()
        {
            OilBarrelModel oil = new OilBarrelModel();
            oil.id = Guid.NewGuid().ToString();
            oil.MaxCapacity = 159;
            oil.CurrentContentValue = 159;
            return oil;
        }
    }
}
