using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.MainFunctions;
using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class BucketEventHandlers
    {
        private IDataService _dataService = MockDataService.GetMockDataService();

        public delegate bool AddBucketDelegate(BucketModel model);

        public event AddBucketDelegate AddBucketEventHandler;

        public BucketEventHandlers item = new BucketEventHandlers();

        public void AddBucket()
        {           
            var item2 = new AddBucketDelegate(_dataService.AddBucketToContainer);
            item.AddBucketEventHandler += item2;
            item.AddBucketEventHandler(BucketExecutions.GenerateBucket());
            item.AddBucketEventHandler -= item2;
        }

        public void EmptyBucket(BucketModel model)
        {
            var item2 = new AddBucketDelegate(_dataService.emptyBucket);
            item.AddBucketEventHandler += item2;
            item.AddBucketEventHandler(model);
            item.AddBucketEventHandler -= item2;
        }

        public void FillBucket(BucketModel model)
        {
            var item2 = new AddBucketDelegate(_dataService.FillBucket);
            item.AddBucketEventHandler += item2;
            item.AddBucketEventHandler(model);
            item.AddBucketEventHandler -= item2;
        }
    }
}
