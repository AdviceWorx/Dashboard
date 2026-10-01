namespace Dashboard.Models
{
    public class ActivityDashboardViewModel
    {
        public DateTime ReportDate { get; set; }

        public List<UserActivity> Users { get; set; } = new();
    }
}