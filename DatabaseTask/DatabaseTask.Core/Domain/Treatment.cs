using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Treatment
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public string Description { get; set; }

        public ICollection<Ward> Wards { get; set; }
            = new List<Ward>();
    }
}
