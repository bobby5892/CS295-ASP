using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintDepartment.Models.Repositories
{
    public interface IComplaintRepository
    {
        List<Complaint> Complaints { get; set; }
    }
}
