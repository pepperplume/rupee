namespace rupees.blazor.Database.Entities;

public class GroupEffort
{
    public int GroupEffortID { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public decimal TotalAmount
    {
        get
        {
            return EffortProfiles
                .Select(x => x.Amount)
                .Sum();
        }
    }

    public List<Profile> EffortProfiles { get; set; } = new List<Profile>();
}
