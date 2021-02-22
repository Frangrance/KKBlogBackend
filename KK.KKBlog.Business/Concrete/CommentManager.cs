using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KK.KKBlog.Business.Interfaces;
using KK.KKBlog.DataAccess.Interfaces;
using KK.KKBlog.Entities.Concrete;

namespace KK.KKBlog.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>,ICommentService
    {
        
        private readonly ICommentDal _commentDal;
        public CommentManager(IGenericDal<Comment> genericDal,ICommentDal commentDal) : base(genericDal)
        {
            
            _commentDal = commentDal;
        }
        public Task<List<Comment>> GetAllWithSubCommentsAsync(int blogId, int? parentId)
        {
           return _commentDal.GetAllWithSubCommentsAsync(blogId,parentId);
        }
    }
}