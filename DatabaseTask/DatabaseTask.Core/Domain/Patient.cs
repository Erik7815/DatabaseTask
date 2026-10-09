using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public Prescription prescription { get; set; }
        public ICollection<Visit> visits { get; set; } = new List<Visit>();
        public ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
    }
}
