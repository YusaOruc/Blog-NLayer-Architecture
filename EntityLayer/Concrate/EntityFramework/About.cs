using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate.EntityFramework
{
    public class About: IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Img { get; set; }
        public string Mail { get; set; }
        public string Degree { get; set; }
        public string City { get; set; }
        public string GitHub { get; set; }
    }
}
