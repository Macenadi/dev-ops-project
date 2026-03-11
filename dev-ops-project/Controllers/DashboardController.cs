using dev_ops_project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dev_ops_project.Models.ViewModels;
using dev_ops_project.Models.Enums;

namespace dev_ops_project.Controllers
{
    public class DashboardController : Controller
    {
      private readonly AppDbContext _context;
        private decimal totalIncome;
        private decimal totalExpense;

        public DashboardController(AppDbContext context)
            {
                _context = context;
            }
        public IActionResult Index()
        {
            var transactions = _context.Transactions
                .Include(t => t.Category)
                .Include(t => t.User)
                .ToList();

            var totalAmount = transactions
                .Where(t => t.Type == TransactionType.Expense)
                .Sum(t => t.Amount);
             
            var ViewModel = new DashboardViewModel
            {
                TotalIncome = totalIncome,
                TotalExpense = totalExpense,
                Balance = totalIncome - totalExpense,
                RecentTransaction = transactions
                   .OrderByDescending(t => t.Date)
                   .Take(5)
                   .ToList()
            };

            return View(ViewModel);
        }
    }
}
