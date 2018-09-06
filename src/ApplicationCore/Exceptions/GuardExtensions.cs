using Cbci.BillsPayment.ApplicationCore.Exceptions;
using Cbci.BillsPayment.ApplicationCore.Entities.BasketAggregate;

namespace Ardalis.GuardClauses
{
    public static class BasketGuards
    {
        public static void NullBasket(this IGuardClause guardClause, int basketId, Basket basket)
        {
            if (basket == null)
                throw new BasketNotFoundException(basketId);
        }
    }
}