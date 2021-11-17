using BusinessLayer.Abstract.Repository;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHomeService: IRepositoryService<Home>
    {
    }
}
