using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Context;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.EntityFramework
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
