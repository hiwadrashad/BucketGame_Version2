using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.MainFunctions
{
    public static class BucketExecutions
    {
        public static BucketModel GenerateBucket()
        {
            BucketModel bucket = new BucketModel();
            bucket.id = Guid.NewGuid().ToString();
            bucket.MaxCapacity = 12;
            bucket.CurrentContentValue = 12;
            return bucket;
        
        }
    }
}
