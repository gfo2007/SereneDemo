﻿using Serenity.ComponentModel;
using System.ComponentModel;

namespace SereneDemo.Northwind
{
    [EnumKey("Northwind.OrderShippingState")]
    public enum OrderShippingState
    {
        [Description("Not Shipped")]
        NotShipped = 0,
        [Description("Shipped")]
        Shipped = 1
    }
}