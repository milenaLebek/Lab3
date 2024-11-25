using System.ComponentModel.DataAnnotations;

namespace zadanie1.Models;

public class UserModel
{
    [Required(ErrorMessage = "Prosze podaj Imię")]
    [MinLength(2)]
    public string Name { get; set; }
    [Required(ErrorMessage = "Prosze podaj Nazwisko")]
    [MinLength(2)]
    public string Surname { get; set; }
    [Required(ErrorMessage = "Prosze podaj Email")]
    [EmailAddress(ErrorMessage = "Prosze podaj poprawny Email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Prosze podaj Hasło")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej jedną małą literę, jedną dużą literę i jedną cyfrę.")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "Prosze podaj Hasło")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Hasła się nie zgadzają")]
    public string ConfirmPassword { get; set; }
    
    [Phone(ErrorMessage = "Prosze podaj poprawny numer telefonu")]
    public string? PhoneNumber { get; set; }
    [Range(10, 80)]
    public int? Age { get; set; }
    public City City { get; set; }
}

public enum City
{
    Kraków,
    Londyn,
    Waszyngton,
    Rzym,
    Warszawa
}