using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.MainFunctions;
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
        public delegate RainBarrelMediumModel? ChooseDelegate();
#nullable disable

        public event ChooseDelegate ChooseEventHandler;

        public RainBarrelMediumEventHandlers item;

        public RainBarrelMediumEventHandlers(RainBarrelMediumEventHandlers initmodel)
        {
            item = initmodel;
        }

        public RainBarrelMediumEventHandlers()
        {

        }
        public void AddMediumBarrel()
        {
            var item2 = new TransformDelegate(_dataService.AddMediumRainBarrelToContainer);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(RainbarrelMediumExecution.generateMediumRainBarrel());
            item.TransformEventHandler -= item2;
        }

        public void EmptyMediumBarrel(RainBarrelMediumModel model)
        {
            var item2 = new TransformDelegate(_dataService.emptyMediumRainBarrel);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

        public void FillMediumBarrel(RainBarrelMediumModel model)
        {
            var item2 = new TransformDelegate(_dataService.FillMediumRainBarrel);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

#nullable enable

        public RainBarrelMediumModel? ChooseMediumBarrel()
        {
            var item2 = new ChooseDelegate(_dataService.chooseMediumBarrel);
            item.ChooseEventHandler += item2;
            var returnvalue = item.ChooseEventHandler();
            item.ChooseEventHandler -= item2;
            return returnvalue;
        }
    }
}
