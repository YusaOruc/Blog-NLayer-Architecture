using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.Repository
{
    public interface IRepositoryService<T> where T:class
    {
        List<T> ListBL();
        T GetBL(int id);
        void InsertBL(T p);
        void UpdateBL(T p);
        void DeleteBL(T p);
        
    }
}
