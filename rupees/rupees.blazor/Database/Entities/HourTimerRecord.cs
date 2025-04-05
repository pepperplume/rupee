using System.ComponentModel.DataAnnotations.Schema;

namespace rupees.blazor.Database.Entities;

public class HourTimerRecord
{
    public int HourTimerRecordID { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime? StartTime { get; set; } = null;
    public bool IsPaused { get; set; } = false;
    public DateTime EstimatedEndTime
    {
        get
        {
            if (StartTime is null) return DateTime.Now;

            return StartTime.Value.Add(Duration);
        }
    }

    public TimeSpan RunningDuration
    {
        get
        {
            var now = DateTime.Now;

            var difference = now - StartTime.Value;

            return Duration.Subtract(difference);
        }
    }

    [NotMapped]
    public bool InDatabase { get; set; } = false;

    public void Pause()
    {
        DateTime now = DateTime.Now;

        var difference = now - StartTime.Value;

        Duration = Duration.Subtract(difference);

        IsPaused = true;
    }

    public void Resume()
    {
        StartTime = DateTime.Now;
        IsPaused = false;
    }
}
