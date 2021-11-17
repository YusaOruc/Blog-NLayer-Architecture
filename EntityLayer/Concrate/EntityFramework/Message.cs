using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate.EntityFramework
{
    public class Message : IEntity
    {
        [Key]
        public int ID { get; set; }
        public string User { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string UserMessage { get; set; }
        public DateTime MessageDate { get; set; }
       
    }
}
