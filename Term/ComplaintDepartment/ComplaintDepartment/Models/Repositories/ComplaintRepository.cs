using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintDepartment.Models.Repositories
{
    public class ComplaintRepository : IComplaintRepository
    {
        AppDBContext context;
        public List<Complaint> Complaints { get; set; }
        public ComplaintRepository(AppDBContext context){
            this.context = context;
        }
        public void AddComplaint(Complaint complaint)
        {
            this.context.Complaints.Add(complaint);
            this.context.SaveChanges();
        }
        public void MarkComplete(Complaint complaint)
        {
            var result = context.Complaints.SingleOrDefault(c => c.ID == complaint.ID);
            if (result != null)
            {
                result.Completed = !result.Completed;
            }
        }
    }
}
