using dev_ops_project.Models.Enums;

namespace dev_ops_project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CategoryType Type { get; set; }
    }
}