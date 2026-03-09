using System.Collections.Generic;

namespace dev_ops_project.Models
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<Transaction> Transactions { get; set; } = new ();
    }
}

