namespace NonProfitLibrary;

public class TransactionType : BaseEntity
{
    [Key]
    public int TransactionTypeId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string ? Name { get; set; }

    [Required(ErrorMessage = "Description is required")]
    public string ? Description { get; set; }

    // public DateTime ? Created { get; set; }
    // public DateTime ? Modified { get; set; }
    // public string ? CreatedBy { get; set; }
    // public string ? ModifiedBy { get; set; }
}
