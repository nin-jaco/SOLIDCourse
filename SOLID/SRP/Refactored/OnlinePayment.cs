using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Refactored
{
    public class OnlinePayment : PaymentModel 
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPayByCreditCard _bankGateway;

        public OnlinePayment(TicketDetails ticketDetails, PaymentDetails paymentDetails) : base(ticketDetails)
        {
            _paymentDetails = paymentDetails;
            _bankGateway = new BankGateway();
        }

        public override void BuyTicket()
        {
            _bankGateway.Charge(_ticketDetails, _paymentDetails);
        }
    }
}
