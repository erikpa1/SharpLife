
using System.ComponentModel.DataAnnotations;

namespace Sl.Api.Authors
{

    public record Author
    {

        [Key]
        public int Id { get; set; } = 0;

        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string MiddleName { get; set; } = string.Empty;


    }

}
