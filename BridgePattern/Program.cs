using System;
using BridgePatternV2.PaymentGateways;
using BridgePatternV2.PaymentMethods;

namespace BridgePatternV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = new AmericanExpress();
            payment.PaymentMedium = new PayWay();
            payment.Pay();

            Console.Read();
        }
    }
}
