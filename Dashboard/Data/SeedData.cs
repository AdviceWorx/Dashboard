using Dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(
            IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            var context = scope.ServiceProvider
                .GetRequiredService<ApplicationDbContext>();

            // Apply pending migrations
            await context.Database.MigrateAsync();

            // Don't duplicate seed data
            if (await context.UserActivities.AnyAsync())
                return;

            var now = DateTime.Now;

            var activities = new List<UserActivity>
            {
                // =====================================================
                // ANGA AVIWE MHLONYANE
                // =====================================================

                new UserActivity
                {
                    ReportDate = DateTime.Today,
                    UserName = "Anga Aviwe Mhlonyane",
                    UserGroup = "Nav",
                    JobTitle = "Software Developer",
                    DeviceName = "ANGA-LAPTOP",
                    WorkHours = 8.25m,
                    ActiveHours = 7.40m,
                    DowntimeHours = 0.85m,
                    M365Hours = 2.15m,
                    InteractiveEvents = 18420,
                    ClockIn = "07:48",
                    ClockOut = "16:15",
                    LocationVerdict = "Office",
                    OfficeBranch = "Johannesburg",
                    City = "Johannesburg",
                    Region = "Gauteng",
                    ISP = "Vumatel",
                    ConnectionType = "Fibre",
                    FirstPublicIP = "102.67.14.21",
                    LastPublicIP = "102.67.14.21",
                    IPChanges = 0,
                    XplanSessions = 14,
                    XplanHours = 3.85m,
                    XplanResources = "Client Portfolio; Risk Profiles; Financial Plans",
                    XplanOvernightSessions = 0,
                    XplanAfterHoursSessions = 1,
                    AnomalyFlags = "",
                    FlagCount = 0,
                    PreviousDayWorkHours = 8.10m,
                    WorkHoursChange = 0.15m,
                    NewUser = "No",
                    ResearchNote = "Normal developer activity.",
                    CreatedAt = now
                },

                new UserActivity
                {
                    ReportDate = DateTime.Today.AddDays(-1),
                    UserName = "Anga Aviwe Mhlonyane",
                    UserGroup = "Nav",
                    JobTitle = "Software Developer",
                    DeviceName = "ANGA-LAPTOP",
                    WorkHours = 8.10m,
                    ActiveHours = 7.25m,
                    DowntimeHours = 0.85m,
                    M365Hours = 2.05m,
                    InteractiveEvents = 17680,
                    ClockIn = "07:55",
                    ClockOut = "16:05",
                    LocationVerdict = "Office",
                    OfficeBranch = "Johannesburg",
                    City = "Johannesburg",
                    Region = "Gauteng",
                    ISP = "Vumatel",
                    ConnectionType = "Fibre",
                    FirstPublicIP = "102.67.14.21",
                    LastPublicIP = "102.67.14.21",
                    IPChanges = 0,
                    XplanSessions = 12,
                    XplanHours = 3.40m,
                    XplanResources = "Client Portfolio; Financial Plans",
                    XplanOvernightSessions = 0,
                    XplanAfterHoursSessions = 0,
                    AnomalyFlags = "",
                    FlagCount = 0,
                    PreviousDayWorkHours = 7.90m,
                    WorkHoursChange = 0.20m,
                    NewUser = "No",
                    ResearchNote = "Normal activity.",
                    CreatedAt = now
                },

                // =====================================================
                // SAM WESI
                // =====================================================

                new UserActivity
                {
                    ReportDate = DateTime.Today,
                    UserName = "Sam Wesi",
                    UserGroup = "IT",
                    JobTitle = "IT",
                    DeviceName = "SAM-DESKTOP",
                    WorkHours = 8.05m,
                    ActiveHours = 6.90m,
                    DowntimeHours = 1.15m,
                    M365Hours = 3.20m,
                    InteractiveEvents = 15240,
                    ClockIn = "08:02",
                    ClockOut = "16:07",
                    LocationVerdict = "Office",
                    OfficeBranch = "Cape Town",
                    City = "Cape Town",
                    Region = "Western Cape",
                    ISP = "Afrihost",
                    ConnectionType = "Fibre",
                    FirstPublicIP = "41.76.45.11",
                    LastPublicIP = "41.76.45.11",
                    IPChanges = 0,
                    XplanSessions = 8,
                    XplanHours = 1.75m,
                    XplanResources = "System Administration; User Management",
                    XplanOvernightSessions = 0,
                    XplanAfterHoursSessions = 0,
                    AnomalyFlags = "",
                    FlagCount = 0,
                    PreviousDayWorkHours = 8.20m,
                    WorkHoursChange = -0.15m,
                    NewUser = "No",
                    ResearchNote = "Routine IT administration activity.",
                    CreatedAt = now
                },

                new UserActivity
                {
                    ReportDate = DateTime.Today.AddDays(-1),
                    UserName = "Sam Wesi",
                    UserGroup = "IT",
                    JobTitle = "IT",
                    DeviceName = "SAM-DESKTOP",
                    WorkHours = 8.20m,
                    ActiveHours = 7.15m,
                    DowntimeHours = 1.05m,
                    M365Hours = 3.35m,
                    InteractiveEvents = 16100,
                    ClockIn = "07:58",
                    ClockOut = "16:10",
                    LocationVerdict = "Office",
                    OfficeBranch = "Cape Town",
                    City = "Cape Town",
                    Region = "Western Cape",
                    ISP = "Afrihost",
                    ConnectionType = "Fibre",
                    FirstPublicIP = "41.76.45.11",
                    LastPublicIP = "41.76.45.11",
                    IPChanges = 0,
                    XplanSessions = 9,
                    XplanHours = 2.00m,
                    XplanResources = "System Administration; Monitoring",
                    XplanOvernightSessions = 0,
                    XplanAfterHoursSessions = 0,
                    AnomalyFlags = "",
                    FlagCount = 0,
                    PreviousDayWorkHours = 8.00m,
                    WorkHoursChange = 0.20m,
                    NewUser = "No",
                    ResearchNote = "Normal IT operations.",
                    CreatedAt = now
                },

                // =====================================================
                // SIZWE NKOSI
                // =====================================================

                new UserActivity
                {
                    ReportDate = DateTime.Today,
                    UserName = "Sizwe Nkosi",
                    UserGroup = "Commissions",
                    JobTitle = "Comms Administrator",
                    DeviceName = "SIZWE-LAPTOP",
                    WorkHours = 7.85m,
                    ActiveHours = 6.60m,
                    DowntimeHours = 1.25m,
                    M365Hours = 4.10m,
                    InteractiveEvents = 13980,
                    ClockIn = "08:12",
                    ClockOut = "16:02",
                    LocationVerdict = "Remote",
                    OfficeBranch = "Durban",
                    City = "Durban",
                    Region = "KwaZulu-Natal",
                    ISP = "MTN",
                    ConnectionType = "5G",
                    FirstPublicIP = "105.22.18.44",
                    LastPublicIP = "105.22.18.48",
                    IPChanges = 2,
                    XplanSessions = 6,
                    XplanHours = 1.45m,
                    XplanResources = "Commission Statements; Adviser Reports",
                    XplanOvernightSessions = 0,
                    XplanAfterHoursSessions = 1,
                    AnomalyFlags = "12h+ day|Early start|Late end",
                    FlagCount = 3,
                    PreviousDayWorkHours = 8.15m,
                    WorkHoursChange = -0.30m,
                    NewUser = "No",
                    ResearchNote = "Multiple IP changes detected during remote session.",
                    CreatedAt = now
                },

                new UserActivity
                {
                    ReportDate = DateTime.Today.AddDays(-1),
                    UserName = "Sizwe Nkosi",
                    UserGroup = "Commissions",
                    JobTitle = "Comms Administrator",
                    DeviceName = "SIZWE-LAPTOP",
                    WorkHours = 8.15m,
                    ActiveHours = 7.00m,
                    DowntimeHours = 1.15m,
                    M365Hours = 4.25m,
                    InteractiveEvents = 14750,
                    ClockIn = "08:00",
                    ClockOut = "16:09",
                    LocationVerdict = "Remote",
                    OfficeBranch = "Durban",
                    City = "Durban",
                    Region = "KwaZulu-Natal",
                    ISP = "MTN",
                    ConnectionType = "5G",
                    FirstPublicIP = "105.22.18.44",
                    LastPublicIP = "105.22.18.44",
                    IPChanges = 0,
                    XplanSessions = 7,
                    XplanHours = 1.60m,
                    XplanResources = "Commission Statements; Adviser Reports",
                    XplanOvernightSessions = 0,
                    XplanAfterHoursSessions = 0,
                    AnomalyFlags = "",
                    FlagCount = 0,
                    PreviousDayWorkHours = 8.05m,
                    WorkHoursChange = 0.10m,
                    NewUser = "No",
                    ResearchNote = "Normal commission administration activity.",
                    CreatedAt = now
                }
            };

            await context.UserActivities.AddRangeAsync(activities);

            await context.SaveChangesAsync();
        }
    }
}