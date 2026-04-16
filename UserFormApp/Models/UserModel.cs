using System.ComponentModel.DataAnnotations;

public class UserModel
{
    [Required(ErrorMessage = "Name is required")]
    public required string Name { get; set; }

    public required string Address { get; set; }

    [Range(18, 120, ErrorMessage = "Age must be 18+")]
    public int Age { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email")]
    public required string Email { get; set; }
}