using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Results
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ResultDate { get; set; }
        public string Result { get; set; }
        public ICollection<Analysis> analyses { get; set; } = new List<Analysis>();


    }
}
