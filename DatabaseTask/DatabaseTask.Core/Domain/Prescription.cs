using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prescription
    {
        [Key]
        public Guid Id { get; set; }
        public string Dose { get; set; }
        public string DailyDoses { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Medicine Medicine { get; set; }

    }
}
