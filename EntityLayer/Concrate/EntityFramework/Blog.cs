using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate.EntityFramework
{
    public class Blog: IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Img { get; set; }
        public string BlogHeader { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogArticle1 { get; set; }
        public string BlogArticle2 { get; set; }
        public string BlogArticle3 { get; set; }
        public string Source { get; set; }
    }
}
