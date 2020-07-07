using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Refactored
{
    public abstract class PaymentModel
    {
        protected TicketDetails _ticketDetails;

        protected PaymentModel(TicketDetails ticketDetails)
        {
            _ticketDetails = ticketDetails;
        }

        public abstract void BuyTicket();
    }
}
