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
    public class HomeManeger : IHomeService
    {
        IHomeDal _homeDal;

        public HomeManeger(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public void DeleteBL(Home p)
        {
            _homeDal.Delete(p);
        }

        public Home GetBL(int id)
        {
            return _homeDal.Get(x=>x.ID==id);
        }

        public void InsertBL(Home p)
        {
            _homeDal.Insert(p);
        }

        public List<Home> ListBL()
        {
            return _homeDal.List();
        }

        public void UpdateBL(Home p)
        {
            _homeDal.Update(p);
        }
    }
}
