using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2.PaymentGateways
{
    class ConvusPay:IPaymentMedium
    {
        public void StartTransaction(string paymentMethod)
        {
            Console.WriteLine($"Payment Medium: {paymentMethod}");
            Console.WriteLine($"Gateway : {PaymentGateway.CorvusPay}");
        }
    }
}
