using System.ComponentModel.DataAnnotations;

namespace Hypance.Core.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
