public class UserActivity
{
    public int Id { get; set; }

    public DateTime ReportDate { get; set; }

    public string UserName { get; set; } = "";
    public string? UserGroup { get; set; }
    public string? JobTitle { get; set; }
    public string? DeviceName { get; set; }

    public decimal? WorkHours { get; set; }
    public decimal? ActiveHours { get; set; }
    public decimal? DowntimeHours { get; set; }
    public decimal? M365Hours { get; set; }
    public long? InteractiveEvents { get; set; }

    public string? ClockIn { get; set; }
    public string? ClockOut { get; set; }

    public string? LocationVerdict { get; set; }
    public string? OfficeBranch { get; set; }

    public string? City { get; set; }
    public string? Region { get; set; }
    public string? ISP { get; set; }
    public string? ConnectionType { get; set; }

    public string? FirstPublicIP { get; set; }
    public string? LastPublicIP { get; set; }
    public int? IPChanges { get; set; }

    public int? XplanSessions { get; set; }
    public decimal? XplanHours { get; set; }
    public string? XplanResources { get; set; }

    public int? XplanOvernightSessions { get; set; }
    public int? XplanAfterHoursSessions { get; set; }

    public string? AnomalyFlags { get; set; }
    public int? FlagCount { get; set; }

    public decimal? PreviousDayWorkHours { get; set; }
    public decimal? WorkHoursChange { get; set; }

    public string? NewUser { get; set; }

    public string? ResearchNote { get; set; }

    public DateTime CreatedAt { get; set; }
}