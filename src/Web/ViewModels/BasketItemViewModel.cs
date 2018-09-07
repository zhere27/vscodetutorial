namespace Cbci.BillsPayment.Web.ViewModels
{
    public class BasketItemViewModel
    {
        public long Id { get; set; }
        public long CatalogItemId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
