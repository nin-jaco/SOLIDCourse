using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Refactored
{
    public class BankGateway : IPayByCreditCard
    {
        public void Charge(TicketDetails ticketDetails, PaymentDetails paymentDetails)
        {
            //charge

        }
    }
}
