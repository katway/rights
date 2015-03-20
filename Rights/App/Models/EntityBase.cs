using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langben.App.Models
{
    public class EntityBase
    {
        public int ID { get; set; }

        public string CreateUserName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}