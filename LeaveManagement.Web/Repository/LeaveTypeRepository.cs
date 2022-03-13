using LeaveManagement.Web.Data;
using LeaveManagement.Web.Interface;

namespace LeaveManagement.Web.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
