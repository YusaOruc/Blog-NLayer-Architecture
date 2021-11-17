using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer2.Abstract
{
    public interface IAdminService<T> where T : class
    {
        Admin GetAdminBL(Admin admin);
    }
}
