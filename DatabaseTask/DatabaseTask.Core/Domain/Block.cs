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
    public class Block 
    {
        [Key]
        public int BlockId { get; set; }
        public string Name { get; set; }
        public int BlockNumber { get; set; }
        public int SecurityLevel { get; set; }
        public ICollection<Prison> Prisons { get; set; } = new List<Prison>();

    }
}
