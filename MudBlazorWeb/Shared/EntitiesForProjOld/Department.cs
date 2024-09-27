using System.ComponentModel.DataAnnotations;

namespace Shared.EntitiesForProj
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsInactive { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}