using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime VisitDate { get; set; }
        public string Reason { get; set; }
        public string Summary { get; set; }
        public Doctor doctor { get; set; }
    }
}
