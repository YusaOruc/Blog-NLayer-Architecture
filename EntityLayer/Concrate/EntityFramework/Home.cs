using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate.EntityFramework
{
    public class Home:IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Img { get; set; }
        public string TopTitle { get; set; }
        public string BottomTitle { get; set; }
    }
}
