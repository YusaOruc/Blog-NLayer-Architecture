using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate.Context;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.EntityFramework
{
    public class EFHomeDal : GenericRepository<Home>, IHomeDal
    {
      
    }
}
