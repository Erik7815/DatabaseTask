using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    internal class Cell
    {
        [Key]
        public int CellId { get; set; }
        public int CellNumber { get; set; }
        public int Floor { get; set; }
        public int MaxCapacity { get; set; }
    }
}
