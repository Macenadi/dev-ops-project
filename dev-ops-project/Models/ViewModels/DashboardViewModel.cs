namespace dev_ops_project.Models.ViewModels
{
    public class DashboardViewModel
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal Balance { get; set; } = 0;

        public List<Transaction> RecentTransaction { get; set; } = new();
    }
}
