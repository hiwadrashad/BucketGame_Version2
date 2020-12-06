using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_Opdracht_Version2.EventHandlers
{
    public class OilBarrelEventHandlers
    {
        public delegate void ExecutionDelegate();

        public event ExecutionDelegate ExecutionEventHandler;
    }
}
