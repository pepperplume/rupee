using rupees.blazor.Database.Entities;

namespace rupees.blazor.Database;

public static class AppState
{
    public static bool IsLoaded { get; set; } = false;

    public static List<Profile> Profiles { get; set; } = new List<Profile>();
    public static List<GroupEffort> GroupEfforts { get; set; } = new List<GroupEffort>();

}
