using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2.PaymentMethods
{
    class Visa:Payment
    {
        public override void Pay()
        {
            PaymentMedium.StartTransaction("Visa");
            Console.WriteLine("Visa Payment Method via {PaymentMedium.GetType().Name}");
        }
    }
}
