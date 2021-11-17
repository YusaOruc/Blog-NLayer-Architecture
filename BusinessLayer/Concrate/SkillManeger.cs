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
    public class SkillManeger : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManeger(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void DeleteBL(Skill p)
        {
            _skillDal.Delete(p);
        }

        public Skill GetBL(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertBL(Skill p)
        {
            _skillDal.Insert(p);
        }

        public List<Skill> ListBL()
        {
            return _skillDal.List();
        }

        public void UpdateBL(Skill p)
        {
            _skillDal.Update(p);
        }
    }
}
