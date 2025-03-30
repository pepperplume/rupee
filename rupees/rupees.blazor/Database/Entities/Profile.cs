using System.ComponentModel.DataAnnotations.Schema;

namespace rupees.blazor.Database.Entities;

public class Profile
{
    public int ProfileID { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Amount { get; set; } = 0;
    public List<Transaction> Transactions { get; set; } = new List<Transaction>();

    [NotMapped]
    public bool InDatabase { get; set; } = false;
}
