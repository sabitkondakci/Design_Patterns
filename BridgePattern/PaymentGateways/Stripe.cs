﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2.PaymentGateways
{
    class Stripe:IPaymentMedium
    {
        public void StartTransaction(string paymentMethod)
        {
            Console.WriteLine($"Payment Method: {paymentMethod}");
            Console.WriteLine($"Gateway : {PaymentGateway.Stripe}");
        }
    }
}
