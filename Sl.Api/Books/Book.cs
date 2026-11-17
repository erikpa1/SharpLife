using System.ComponentModel.DataAnnotations;

public record Book {
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
}

public record BookDto {
    [Required] int Id { get; set; } = 0;
    [Required][StringLength(50)] string Name { get; set; } = string.Empty;

}
