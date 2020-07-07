using System;

namespace SOLID.DIP
{
    /// <summary>
    /// two physical devices represented by two classes
    /// </summary>
    public class GainDivergenceChecker
    {
        /// <summary>
        /// constructor injection
        /// </summary>
        private IAccounter _privateAccounter;
        private IFiscalRegistrator _fr;
        
        public GainDivergenceChecker(IAccounter accounter, IFiscalRegistrator fr)
        {
            _privateAccounter = accounter;
            _fr = fr;
        }

        ///property injection
        public IAccounter Acccounter { get; set; }
        public IFiscalRegistrator FiscalRegistrator { get; set; }

        ///method injection
        public bool HasDivergence(IAccounter iAccounter, IFiscalRegistrator fiscalRegistrator)
        {
            //rest of method below
            return false;
        }


        /// <summary>
        /// checks if there is a divergence between two devices
        /// physical devices are inclined to inoperation so easy to unit test
        /// </summary>
        /// <returns></returns>
        public bool HasDivergence()
        {                        
            decimal salesSumm = _privateAccounter.GetSalesSumm();
            decimal summOfReturnedTickets = _privateAccounter.GetSummOfReturnedTickets();
                        
            decimal salesSummByFiscalRegistrator = _fr.GetSalesSumm();
            decimal summOfReturnedTicketsByFiscalRegistrator = _fr.GetSummOfReturnedTickets();

            return salesSumm == salesSummByFiscalRegistrator &&
                   summOfReturnedTickets == summOfReturnedTicketsByFiscalRegistrator;
        }

        private void ValidateDependencies(Accounter accounter, FiscalRegistrator fr)
        {
            if (accounter == null)
                throw new ArgumentNullException("accounter");
            if (fr == null)
                throw new ArgumentNullException("fr");
        }
    }

    public interface IFiscalRegistrator
    {
        decimal GetSalesSumm();
        decimal GetSummOfReturnedTickets();
    }

    public class FiscalRegistrator : IFiscalRegistrator
    {
        public decimal GetSalesSumm()
        {
            return 0;
        }

        public decimal GetSummOfReturnedTickets()
        {
            return 0;
        }
    }

    public interface IAccounter
    {
        decimal GetSalesSumm();
        decimal GetSummOfReturnedTickets();
    }

    public class Accounter : IAccounter
    {
        public decimal GetSalesSumm()
        {
            return 0;
        }

        public decimal GetSummOfReturnedTickets()
        {
            return 0;
        }
    }
}
