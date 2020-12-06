using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class RainBarrelMediumEventHandlers
    {
        private IDataService _dataService = MockDataService.GetMockDataService();

        public delegate bool TransformDelegate(RainBarrelMediumModel model);

        public event TransformDelegate TransformEventHandler;

#nullable enable
        public delegate RainBarrelLargeModel? ChooseDelegate();
#nullable disable

        public event ChooseDelegate ChooseEventHandler;

        public RainBarrelLargeEventHandlers item = new RainBarrelLargeEventHandlers();

//        public void AddLargeBarrel()
//        {
//            var item2 = new TransformDelegate(_dataService.AddLargeRainBarrelToContainer);
//            item.TransformEventHandler += item2;
//            item.TransformEventHandler(RainBarrelLargeExecution.GenerateLargeRainBarrel());
//            item.TransformEventHandler -= item2;
//        }

//        public void EmptyLargeBarrel(RainBarrelLargeModel model)
//        {
//            var item2 = new TransformDelegate(_dataService.emptyLargeRainBarrel);
//            item.TransformEventHandler += item2;
//            item.TransformEventHandler(model);
//            item.TransformEventHandler -= item2;
//        }

//        public void FillLargeBarrel(RainBarrelLargeModel model)
//        {
//            var item2 = new TransformDelegate(_dataService.FillLargeRainBarrel);
//            item.TransformEventHandler += item2;
//            item.TransformEventHandler(model);
//            item.TransformEventHandler -= item2;
//        }

//#nullable enable

//        public RainBarrelLargeModel? ChooseLargeBarrel()
//        {
//            var item2 = new ChooseDelegate(_dataService.chooseLargeBarrel);
//            item.ChooseEventHandler += item2;
//            var returnvalue = item.ChooseEventHandler();
//            item.ChooseEventHandler -= item2;
//            return returnvalue;
//        }
    }
}
