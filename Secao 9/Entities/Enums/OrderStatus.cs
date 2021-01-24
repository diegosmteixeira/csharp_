using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_9.Entities.Enums
{
    //OrderStatus é derivado de um timpo int => : int
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
