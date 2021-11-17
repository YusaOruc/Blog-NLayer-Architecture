using BusinessLayer.Abstract;

using DataAccessLayer.Abstract;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class MessageManeger : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManeger(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void DeleteBL(Message p)
        {
            throw new NotImplementedException();
        }

        public Message GetBL(int id)
        {
            return _messageDal.Get(x=>x.ID==id);
        }

        public void InsertBL(Message p)
        {
            p.MessageDate = DateTime.Now;
            _messageDal.Insert(p);
        }

        public List<Message> ListBL()
        {
            return _messageDal.List();
        }

        public void UpdateBL(Message p)
        {
            throw new NotImplementedException();
        }
    }
}
