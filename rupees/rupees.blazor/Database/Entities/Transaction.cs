using System.ComponentModel.DataAnnotations.Schema;

namespace rupees.blazor.Database.Entities;

public class Transaction
{
    public int TransactionID { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; } = 0;

    [NotMapped]
    public bool InDatabase { get; set; } = false;
}
