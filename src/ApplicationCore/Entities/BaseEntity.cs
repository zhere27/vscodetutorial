using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column("Id", TypeName = "bigint", Order = 0)]
        public long Id { get; set; }
    }
}