using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Context;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrate.Context;

namespace DataAccessLayer.Concrate.EntityFramework
{
    public class EFBlogDal : GenericRepository<Blog>, IBlogDal
    {
        Context.Context context = new Context.Context();
        public List<Blog> GetLastWord()
        {
            return context.Blogs.OrderByDescending(x => x.ID).Take(5).ToList();
        }
    }
}
