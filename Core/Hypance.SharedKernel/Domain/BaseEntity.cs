using System.ComponentModel.DataAnnotations;

namespace Hypance.SharedKernel.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
