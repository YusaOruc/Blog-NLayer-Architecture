using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class BlogManeger : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManeger(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void DeleteBL(Blog p)
        {
            _blogDal.Delete(p);
        }

        public Blog GetBL(int id)
        {
            return _blogDal.Get(x=>x.ID==id);
        }

        public List<Blog> GetLastWordBL()
        {
            return _blogDal.GetLastWord();
        }

        public void InsertBL(Blog p)
        {
            _blogDal.Insert(p);
        }

        public List<Blog> ListBL()
        {
            return _blogDal.List();
        }

        public void UpdateBL(Blog p)
        {
            _blogDal.Update(p);
        }
    }
}
