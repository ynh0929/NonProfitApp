namespace NonProfitLibrary;

public class ContactList : BaseEntity
{
    [Key]
    public int AccountNo { get; set; }

    [Required(ErrorMessage = "First Name is required")]
     [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Enter Valid First Name")]
    public string ? FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
     [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Enter Valid Last Name")]
    public string ? LastName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Enter valid Email")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string ? Email { get; set; }

    [Required(ErrorMessage = "Street is required")]
    public string ? Street { get; set; }

    [Required(ErrorMessage = "City is required")]
    public string ? City { get; set; }

    [Required(ErrorMessage = "Postal Code is required")]
    public string ? PostalCode { get; set; }

    [Required(ErrorMessage = "Country is required")]
    public string ? Country { get; set; }

    // public DateTime ? Created { get; set; }
    // public DateTime ? Modified { get; set; }
    // public string ? CreatedBy { get; set; }
    // public string ? ModifiedBy { get; set; }
}