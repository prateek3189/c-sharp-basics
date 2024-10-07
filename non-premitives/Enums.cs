using System;

namespace NonPremitives
{
    public enum ShippingMethod
    {
        Air = 1,
        Bus = 2,
        Train = 3,
    }

    class Enums
    {
        public static void init()
        {
            var method = ShippingMethod.Air;
            System.Console.WriteLine((int)method);
            System.Console.WriteLine((ShippingMethod)3);

            System.Console.WriteLine(method.ToString());

            var newMethod = "Cycle";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), newMethod);

            System.Console.WriteLine(shippingMethod);
        }
    }
}
