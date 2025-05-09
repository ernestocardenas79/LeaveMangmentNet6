using System.ComponentModel.DataAnnotations;

namespace LeaveManagment.W3b.Data
{
    public class LeaveType : BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }
        public int NumberOfDays { get; set; }
    }
}
