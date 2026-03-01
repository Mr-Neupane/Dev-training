using System.ComponentModel.DataAnnotations.Schema;

namespace Dotnet_Mvc.Entities
{
    [Table("branch", Schema = "general_setup")]
    public class Branch : BaseEntity
    {
        public string BranchName { get; set; }
        public string? BranchAddress { get; set; }
        public string? BranchPhone { get; set; }
        public int RecById { get; set; }
        public virtual User RecBy { get; set; }
    }
}