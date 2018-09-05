using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Interfaces;
using Ardalis.GuardClauses;
using ApplicationCore.Services;

namespace ApplicationCore.Entities
{
    [Table("Channels")]
    public class Channel : BaseEntity
    {
        private readonly IAppLogger<ChannelService> _logger;

        private readonly List<Branch> _items = new List<Branch>();

        public Channel()
        {
            //required by EF
        }

        public Channel(string accountCode, string accountName, string status, Address address)
        {
            Guard.Against.NullOrEmpty(accountCode,nameof(accountCode));
            Guard.Against.NullOrEmpty(accountName,nameof(accountCode));
            Guard.Against.NullOrEmpty(status,nameof(status));
            Guard.Against.Null(address, nameof(address));

            AccountCode = accountCode;
            AccountName = accountName;
            Address = address;
            Status = status;
        }

        [Required]
        [StringLength(100)]
        [Column("AccountCode", TypeName = "varchar", Order = 1)]
        public string AccountCode { get; private set; }

        [Required]
        [Column("AccountName", TypeName = "varchar", Order = 2)]
        public string AccountName { get; private set; }

        [StringLength(50)]
        [Column("Status", TypeName = "varchar", Order = 3)]
        public string Status { get; private set; }

        public Address Address { get; private set; }

        public ICollection<Branch> Branch { get; set; }

        public IReadOnlyCollection<Branch> Branches => _items.AsReadOnly();

    }

}