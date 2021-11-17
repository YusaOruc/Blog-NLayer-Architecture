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
    public class MyPortfolioManeger : IMyPortfolioService
    {
        IMyPortfolioDal _my;

        public MyPortfolioManeger(IMyPortfolioDal my)
        {
            _my = my;
        }

        public void DeleteBL(MyPortfolio p)
        {
            _my.Delete(p);
        }

        public MyPortfolio GetBL(int id)
        {
            return _my.Get(x=>x.ID==id);
        }

        public void InsertBL(MyPortfolio p)
        {
            _my.Insert(p);
        }

        public List<MyPortfolio> ListBL()
        {
            return _my.List();
        }

        public void UpdateBL(MyPortfolio p)
        {
            _my.Update(p);
        }
    }
}
