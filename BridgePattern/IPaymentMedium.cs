using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePatternV2
{
    public enum PaymentGateway
    {
        PayWay,
        PayPal,
        CorvusPay,
        Stripe
    };
    public interface IPaymentMedium
    {
        void StartTransaction(string paymentMethod);
    }
}
