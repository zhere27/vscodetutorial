using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class Tpa : BaseEntity
    {
        [Required]
        [StringLength(50)]
        [Column("TpaId", TypeName = "varchar", Order = 1)]
        public string TpaId { get; set; }

        [Column("BranchId", TypeName = "bigint", Order = 2)]
        public long BranchId { get; set; }

        [StringLength(50)]
        [Column("Status", TypeName = "varchar", Order = 3)]
        public string Status { get; set; }

        public virtual Branch Branch { get; set; }

    }
}