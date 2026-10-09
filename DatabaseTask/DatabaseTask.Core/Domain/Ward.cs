using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseTask.Core.Domain;

namespace DatabaseTask.Core.Domain
{
    public class Ward 
    {
        [Key]
        public Guid Id { get; set; }
        public int WardNr { get; set; }
        public int Floor { get; set; }
        public int Beds { get; set; }

    }
}
