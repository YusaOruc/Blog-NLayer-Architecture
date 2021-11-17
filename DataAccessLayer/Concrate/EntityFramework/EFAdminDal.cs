using DataAccessLayer.Abstract;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrate.Context;


namespace DataAccessLayer.Concrate.EntityFramework
{
    
    public class EFAdminDal : IAdminDal
    {
        Context.Context context = new Context.Context();

        public void Delete(Admin p)
        {
            throw new NotImplementedException();
        }

        public Admin Get(Expression<Func<Admin, bool>> filter)
        {
            return context.Admins.FirstOrDefault(filter);
        }

        public Admin GetAdminDal(Admin admin)
        {
            return context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
        }

        public void Insert(Admin p)
        {
            throw new NotImplementedException();
        }

        public List<Admin> List()
        {
            throw new NotImplementedException();
        }

        public List<Admin> List(Expression<Func<Admin, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin p)
        {
            throw new NotImplementedException();
        }
    }
}
