using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int WorkerId { get; set; }
        public string PhoneNr { get; set; }
        public string Specialty { get; set; }
        public ICollection<Department> Departments { get; set; }
            = new List<Department>();
    }
}
