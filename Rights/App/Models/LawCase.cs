using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langben.App.Models
{
    public class LawCase : EntityBase
    {

        public string Name { get; set; }
        public string CaseNumber { get; set; }
        public string CaseInfo { get; set; }
        public string ExistingAppraisal { get; set; }
        public DateTime? HappenedTime { get; set; }
        public List<Sample> Samples { get; set; }
        public string Remark { get; set; }



    }
}