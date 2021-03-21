using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2.PaymentMethods
{
    class AmericanExpress:Payment
    {
        public override void Pay()
        {
            PaymentMedium.StartTransaction("American Express");
            Console.WriteLine($"AmericanExpress Payment Method Invoked via {PaymentMedium.GetType().Name}");
        }
    }
}
