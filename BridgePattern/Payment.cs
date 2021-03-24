using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2
{
    //composite abstract class
    public abstract class Payment
    {
        // the bridge which connects Payment ----> IPaymentMedium
        public IPaymentMedium PaymentMedium;
        public abstract void Pay();
    }
}
