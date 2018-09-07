using Cbci.BillsPayment.ApplicationCore.Specifications;
using Cbci.BillsPayment.ApplicationCore.Entities;
using Cbci.BillsPayment.ApplicationCore.Entities.BasketAggregate;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Cbci.BillsPayment.UnitTests
{
    public class BasketWithItems
    {
        private int _testBasketId = 123;

        [Fact]
        public void MatchesBasketWithGivenId()
        {
            var spec = new BasketWithItemsSpecification(_testBasketId);

            var result = GetTestBasketCollection()
                .AsQueryable()
                .FirstOrDefault(spec.Criteria);

            Assert.NotNull(result);
            Assert.Equal(_testBasketId, result.Id);

        }

        [Fact]
        public void MatchesNoBasketsIfIdNotPresent()
        {
            int badId = -1;
            var spec = new BasketWithItemsSpecification(badId);

            Assert.False(GetTestBasketCollection()
                .AsQueryable()
                .Any(spec.Criteria));
        }

        public List<Basket> GetTestBasketCollection()
        {
            return new List<Basket>()
            {
                new Basket() { Id = 1 },
                new Basket() { Id = 2 },
                new Basket() { Id = _testBasketId }
            };
        }
    }
}
