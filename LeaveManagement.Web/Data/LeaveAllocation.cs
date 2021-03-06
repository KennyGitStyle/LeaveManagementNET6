using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; } = null!;
        [ForeignKey("LeaveTypeId")]
        public int LeaveTypeId { get; set; }
        public string EmployeeId { get; set; } = null!;
        
    }
}
