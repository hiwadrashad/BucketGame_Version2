using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.MainFunctions;
using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class OilBarrelEventHandlers
    {
        private IDataService _dataService = MockDataService.GetMockDataService();

        public delegate bool TransformDelegate(OilBarrelModel model);

        public event TransformDelegate TransformEventHandler;

#nullable enable
        public delegate OilBarrelModel? ChooseDelegate();
#nullable disable

        public event ChooseDelegate ChooseEventHandler;

        public OilBarrelEventHandlers item = new OilBarrelEventHandlers();

        public void AddOilBarrel()
        {
            var item2 = new TransformDelegate(_dataService.AddOilBarrelToContainer);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(OilBarrelExecution.GenerateOilBarrel());
            item.TransformEventHandler -= item2;
        }

        public void EmptyOilBarrel(OilBarrelModel model)
        {
            var item2 = new TransformDelegate(_dataService.emptyOilBarrel);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

        public void FillOilBarrel(OilBarrelModel model)
        {
            var item2 = new TransformDelegate(_dataService.FillOilBarrel);
            item.TransformEventHandler += item2;
            item.TransformEventHandler(model);
            item.TransformEventHandler -= item2;
        }

#nullable enable

        public OilBarrelModel? ChooseOilBarrel()
        {
            var item2 = new ChooseDelegate(_dataService.chooseOilBarrel);
            item.ChooseEventHandler += item2;
            var returnvalue = item.ChooseEventHandler();
            item.ChooseEventHandler -= item2;
            return returnvalue;
        }
    }
}
