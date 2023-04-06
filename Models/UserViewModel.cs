using System.ComponentModel.DataAnnotations;

public class CustomerWithPassword
{
    public Customer Customer { get; set; }
    [UIHint("password"), Required]
    public string Password { get; set; }
}
