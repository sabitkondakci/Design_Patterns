using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2.PaymentMethods
{
    class Master:Payment
    {
        public override void Pay()
        { 
            PaymentMedium.StartTransaction("Master");
            Console.WriteLine("Master Payment Method via {PaymentMedium.GetType().Name}");
        }
    }
}
