using Bucket_Opdracht_Version2.DAL;
using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class ContainerEventHandlers
    {

        private IDataService _dataService = MockDataService.GetMockDataService();

        public delegate bool TransformDelegate();

        public event TransformDelegate TransformEventHandler;

#nullable enable
        public delegate ContainerModel? ChooseDelegate();
#nullable disable

        public event ChooseDelegate ChooseEventHandler;

        public ContainerEventHandlers item;

        public ContainerEventHandlers(ContainerEventHandlers initmodel)
        {
            item = initmodel;
        }

        public ContainerEventHandlers()
        {

        }
        public void AddContainer()
        {
            var item2 = new TransformDelegate(_dataService.AddContainer);
            item.TransformEventHandler += item2;
            item.TransformEventHandler();
            item.TransformEventHandler -= item2;
        }

#nullable enable

        public ContainerModel? ChooseContainer()
        {
            var item2 = new ChooseDelegate(_dataService.chooseContainer);
            item.ChooseEventHandler += item2;
            var returnvalue = item.ChooseEventHandler();
            item.ChooseEventHandler -= item2;
            return returnvalue;
        }

    }
}
