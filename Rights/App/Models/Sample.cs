using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langben.App.Models
{
    public class Sample : EntityBase
    {

        public LawCase LawCase { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Package { get; set; }
        public string Properties { get; set; }
    }
}