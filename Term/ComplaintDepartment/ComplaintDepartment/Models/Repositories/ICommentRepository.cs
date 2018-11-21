using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintDepartment.Models.Repositories
{
    public interface ICommentRepository
    {
        List<Comment> Comments { get; set; }
    }
}
