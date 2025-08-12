namespace HRSolutions.Models
{
    public class EmployeeProfileViewModel
    {
        public Employee? SelectedEmployee { get; set; }
        public List<string> PreferredNames { get; set; } = new List<string>();
        public string? SelectedPreferredName { get; set; }
    }
}
