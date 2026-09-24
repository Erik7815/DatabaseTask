using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


namespace DatabaseTask.Core.Domain
{
    public class Prison
    {
        [Key]
        public int PrisonID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        public int Capacity { get; set; }
    }
}

