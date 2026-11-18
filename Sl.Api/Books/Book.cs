using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sl.Api.Authors;

public record Book
{
    [Key]
    public int Id { get; set; } = 0;

    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [ForeignKey(nameof(Author))]
    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;

}

public record BookDto
{
    [Required] int Id { get; set; } = 0;
    [Required][StringLength(50)] string Name { get; set; } = string.Empty;

}
