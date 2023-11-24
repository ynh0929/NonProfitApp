namespace NonProfitLibrary;

public class PaymentMethod : BaseEntity
{
    [Key]
    public int PaymentMethodId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string ? Name { get; set; }

    // public DateTime ? Created { get; set; }
    // public DateTime ? Modified { get; set; }
    // public string ? CreatedBy { get; set; }
    // public string ? ModifiedBy { get; set; }

}
