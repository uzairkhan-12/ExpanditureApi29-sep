using System;

namespace ExpanditureApi29_sep.Models
{
    public class ExpenditureType
    {
        public int Id { get; set; }
        public string ExpenditureTypeName { get; set; }
        public DateTime AddedOn { get; set; }
        public bool IsActive { get; set; }
    }
}