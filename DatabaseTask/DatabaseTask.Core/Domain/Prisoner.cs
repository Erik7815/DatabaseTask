using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    internal class Prisoner
    {
        [Key]
        public int PrisonerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int PersonalId { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public ICollection<Cell> Cells { get; set; } = new List<Cell>();
        public ICollection<Crime> Crimes { get; set; } = new List<Crime>();
    }
}
