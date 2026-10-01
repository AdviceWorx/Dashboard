using Dashboard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Controllers.Api
{
    [ApiController]
    [Route("api/activity")]
    public class ActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            [FromQuery] string period = "daily",
            [FromQuery] DateTime? date = null)
        {
            var selectedDate = (date ?? DateTime.Today).Date;

            DateTime startDate;
            DateTime endDate;

            switch (period.ToLower())
            {
                case "weekly":
                    // Monday = start of week
                    int daysFromMonday =
                        ((int)selectedDate.DayOfWeek + 6) % 7;

                    startDate = selectedDate.AddDays(-daysFromMonday);
                    endDate = startDate.AddDays(7);
                    break;

                case "monthly":
                    startDate = new DateTime(
                        selectedDate.Year,
                        selectedDate.Month,
                        1);

                    endDate = startDate.AddMonths(1);
                    break;

                case "daily":
                default:
                    startDate = selectedDate;
                    endDate = startDate.AddDays(1);
                    period = "daily";
                    break;
            }

            var data = await _context.UserActivities
                .AsNoTracking()
                .Where(x =>
                    x.ReportDate >= startDate &&
                    x.ReportDate < endDate)
                .OrderBy(x => x.ReportDate)
                .ThenBy(x => x.UserName)
                .Select(x => new
                {
                    report_date = x.ReportDate,

                    user_name = x.UserName,
                    user_group = x.UserGroup,
                    job_title = x.JobTitle,
                    device_name = x.DeviceName,

                    work_hours = x.WorkHours,
                    active_hours = x.ActiveHours,
                    downtime_hours = x.DowntimeHours,
                    m365_hours = x.M365Hours,
                    interactive_events = x.InteractiveEvents,

                    clock_in = x.ClockIn,
                    clock_out = x.ClockOut,

                    location_verdict = x.LocationVerdict,
                    office_branch = x.OfficeBranch,
                    city = x.City,
                    region = x.Region,

                    isp = x.ISP,
                    connection_type = x.ConnectionType,

                    first_public_ip = x.FirstPublicIP,
                    last_public_ip = x.LastPublicIP,
                    ip_changes = x.IPChanges,

                    xplan_sessions = x.XplanSessions,
                    xplan_hours = x.XplanHours,
                    xplan_resources = x.XplanResources,
                    xplan_overnight_sessions =
                        x.XplanOvernightSessions,
                    xplan_after_hours_sessions =
                        x.XplanAfterHoursSessions,

                    anomaly_flags = x.AnomalyFlags,
                    flag_count = x.FlagCount,

                    prev_day_work_hours =
                        x.PreviousDayWorkHours,

                    work_hours_change =
                        x.WorkHoursChange,

                    new_user = x.NewUser,
                    research_note = x.ResearchNote
                })
                .ToListAsync();

            return Ok(new
            {
                period = period,
                start_date = startDate,
                end_date = endDate.AddDays(-1),
                total_records = data.Count,
                data = data
            });
        }
    }
}