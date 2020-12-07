using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.MainFunctions;
using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class RainBarrelSmallEventhandlers
    {
        private IDataService _dataService = MockDataService.GetMockDataService();

        public delegate bool TransformDelegate(RainbarrelSmallModel model);

        public event TransformDelegate TransformEventHandler;

#nullable enable
        public delegate RainbarrelSmallModel? ChooseDelegate();
#nullable disable

        public event ChooseDelegate ChooseEventHandler;

        public RainBarrelSmallEventhandlers item;

        public RainBarrelSmallEventhandlers(RainBarrelSmallEventhandlers initmodel)
        {
            item = initmodel;
        }

        public RainBarrelSmallEventhandlers()
        {

        }
        public void AddSmallBarrel()
        {
            var item2 = new TransformDelegate(_dataService.AddSmallRainBarrelToContainer);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(RainBarrelSmallExecution.generateSmallRainbarrel());
            item.TransformEventHandler -= item2;
        }

        public void EmptySmallBarrel(RainbarrelSmallModel model)
        {
            var item2 = new TransformDelegate(_dataService.emptySmallRainBarrel);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

        public void FillSmallBarrel(RainbarrelSmallModel model)
        {
            var item2 = new TransformDelegate(_dataService.FillSmallRainBarrel);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

#nullable enable

        public RainbarrelSmallModel? ChooseSmallBarrel()
        {
            var item2 = new ChooseDelegate(_dataService.chooseSmallBarrel);
            item.ChooseEventHandler += item2;
            var returnvalue = item.ChooseEventHandler();
            item.ChooseEventHandler -= item2;
            return returnvalue;
        }
    }
}
