using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Floor { get; set; }
        public int PhoneNr { get; set; }
    }
}

