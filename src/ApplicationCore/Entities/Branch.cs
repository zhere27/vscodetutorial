using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ardalis.GuardClauses;

namespace ApplicationCore.Entities
{
    public class Branch : BaseEntity
    {
        public Branch()
        {

        }
        public Branch(Address address)
        {
            Guard.Against.Null(address, nameof(address));

            Address = address;
        }

        [Required]
        [StringLength(50)]
        [Column("Code", TypeName = "varchar", Order = 1)]
        public string BranchCode { get; set; }

        [StringLength(100)]
        [Column("Name", TypeName = "varchar", Order = 2)]
        public string BranchName { get; set; }

        [StringLength(50)]
        [EmailAddress]
        [Column("Email", TypeName = "varchar", Order = 3)]
        public string Email { get; set; }

        [Column("ChannelId", TypeName = "bigint", Order = 4)]
        public long ChannelId { get; set; }
        public Address Address { get; private set; }
        public virtual Channel Channel { get; set; }

        public virtual ICollection<Tpa> Tpa { get; set; }
    }

}