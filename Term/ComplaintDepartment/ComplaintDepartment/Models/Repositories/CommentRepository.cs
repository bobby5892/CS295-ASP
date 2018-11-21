using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComplaintDepartment.Models;
namespace ComplaintDepartment.Models.Repositories
{
    public class CommentRepository :ICommentRepository
    {
        AppDBContext context;

        public List<Comment> Comments { get; set; }
        public CommentRepository(AppDBContext context)
        {
            this.context = context;
        }

        public void AddComment (Comment comment)
        {
            this.context.Comments.Add(comment);
            this.context.SaveChanges();
        }
    }
}
