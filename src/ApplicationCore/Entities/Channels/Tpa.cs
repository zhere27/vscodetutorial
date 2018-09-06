namespace Cbci.BillsPayment.ApplicationCore.Entities.Channels
{
    public class Tpa : BaseEntity
    {
        public string TpaId { get; set; }

        public long BranchId { get; set; }

        public string Status { get; set; }

        public virtual Branch Branch { get; set; }

    }
}