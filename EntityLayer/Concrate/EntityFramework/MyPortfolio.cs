using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate.EntityFramework
{
    public class MyPortfolio: IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Img { get; set; }
        public string Link { get; set; }
        public string Header { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }

    }
}
