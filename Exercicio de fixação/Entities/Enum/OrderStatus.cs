using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_fixação.Entities.Enum
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
