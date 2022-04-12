using System.ComponentModel.DataAnnotations;

public class Test
{
    [Required]
    [StringLength(3, MinimumLength = 3)]
    public string? Something { get; set; }
}