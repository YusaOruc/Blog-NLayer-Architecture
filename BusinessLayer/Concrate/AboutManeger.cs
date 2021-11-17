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
    public class AboutManeger : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManeger(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void DeleteBL(About p)
        {
            _aboutDal.Delete(p);
        }

        public About GetBL(int id)
        {
            return _aboutDal.Get(x=>x.ID==id);
        }

        public void InsertBL(About p)
        {
            _aboutDal.Insert(p);
        }

        public List<About> ListBL()
        {
            return _aboutDal.List();
        }

        public void UpdateBL(About p)
        {
            _aboutDal.Update(p);
        }
    }
}
