using BusinessLayer2.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer2.Concrate
{
    public class AdminManeger : IAdminService<Admin>
    {
        IAdminDal _adminDal;

        public AdminManeger(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetAdminBL(Admin admin)
        {
            return _adminDal.GetAdminDal(admin);
        }
    }
}
