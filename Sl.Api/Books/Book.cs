using System.ComponentModel.DataAnnotations;

public record Book {
    [Required] int Id { get; set; } = 0;
    [Required][StringLength(50)] string Name { get; set; } = string.Empty;

}
