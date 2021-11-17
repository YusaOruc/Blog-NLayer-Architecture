using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate.EntityFramework
{
    public class Skill: IEntity
    {
        [Key]
        public int ID { get; set; }
        public string SkillsName { get; set; }
        public int Percent { get; set; }
    }
}
