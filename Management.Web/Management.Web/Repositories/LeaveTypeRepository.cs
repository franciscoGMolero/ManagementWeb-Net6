using Management.Web.Data;

namespace Management.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
