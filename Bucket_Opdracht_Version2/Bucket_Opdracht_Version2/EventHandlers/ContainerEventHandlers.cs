using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class ContainerEventHandlers
    {

        public delegate void ExecutionDelegate();

        public event ExecutionDelegate ExecutionEventHandler;
        //public event EventHandler Treshhodl;

        //public void execute()
        //{
        //    EventHandler handler = Treshhodl;
        //    handler?.Invoke(this,)
        //}
        //public delegate void Add(int something);
        //public void ContainerEventHandler()
        ////{
        ////    usethissomething obj = new usethissomething(Test);
        ////    obj.Invoke(12);
        //}

    }
}
