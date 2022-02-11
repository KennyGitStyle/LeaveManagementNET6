namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string LeaveName { get; set; } = null!;
        public int DefaultDays { get; set; }
       
    }
}
