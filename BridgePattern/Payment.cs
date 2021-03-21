using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2
{
    public abstract class Payment
    {
        // the bridge which connects Payment ----> IPaymentMedium
        public IPaymentMedium PaymentMedium;
        public abstract void Pay();
    }
}
