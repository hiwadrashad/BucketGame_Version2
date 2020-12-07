using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.MainFunctions;
using Bucket_Opdracht_Version2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class BucketEventHandlers
    {
        private IDataService _dataService = MockDataService.GetMockDataService();

        public delegate bool TransformDelegate(BucketModel model);

        public event TransformDelegate TransformEventHandler;

#nullable enable
        public delegate BucketModel? ChooseDelegate();
#nullable disable

        public event ChooseDelegate ChooseEventHandler;

        public BucketEventHandlers item;

        public BucketEventHandlers(BucketEventHandlers initmodel)
        {
            item = initmodel;
        }

        public BucketEventHandlers()
        {
                
        }

        public void test()
        {
            Console.WriteLine("this works");
        }
        public void AddBucket()
        {
            var item2 = new TransformDelegate(_dataService.AddBucketToContainer);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(BucketExecutions.GenerateBucket());
            item.TransformEventHandler -= item2;
        }

        public void EmptyBucket(BucketModel model)
        {
            var item2 = new TransformDelegate(_dataService.emptyBucket);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

        public void FillBucket(BucketModel model)
        {
            var item2 = new TransformDelegate(_dataService.FillBucket);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

#nullable enable

        public BucketModel? ChooseBucket()
        {
            var item2 = new ChooseDelegate(_dataService.chooseBucket);
            item.ChooseEventHandler += item2;
            var returnvalue = item.ChooseEventHandler();
            item.ChooseEventHandler -= item2;
            return returnvalue;
        }
    }
}
