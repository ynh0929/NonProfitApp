namespace NonProfitLibrary;

public class Donation : BaseEntity
{
    [Key]
    public int TransId { get; set; }

    [Required(ErrorMessage = "Date is required")]
    public DateTime Date { get; set; }

    [ForeignKey("ContactList")] 
    public int AccountNo { get; set; } //Foreign key to ContactList

    [ForeignKey("TransactionType")]
    public int TransactionTypeId { get; set; } //Foreign key to TransactionType

    [Required(ErrorMessage = "Amount is required")]
    [Range(0.01, float.MaxValue, ErrorMessage = "Amount must be greater than 0")]
    public float Amount { get; set; }

    [ForeignKey("PaymentMethod")] 
    public int PaymentMethodId { get; set; } //Foreign key to PaymentMethod

    [Required(ErrorMessage = "Notes is required")]
    public string ? Notes { get; set; }

    // public int ContactListAccountNo { get; set; }

    // public DateTime ? Created { get; set; }
    // public DateTime ? Modified { get; set; }
    // public string ? CreatedBy { get; set; }
    // public string ? ModifiedBy { get; set; }

    // public virtual ContactList? ContactLists { get; set; }
    // public virtual TransactionType? TransactionTypes { get; set; }
    // public virtual PaymentMethod? PaymentMethods { get; set; }

}
