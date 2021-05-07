using System.ComponentModel.DataAnnotations;

namespace apiwithonion.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
