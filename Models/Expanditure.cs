using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpanditureApi.Models
{
    public class Expanditure
    {
        public int ID { get; set; }
        public int TypeId { get; set; }
        //public ExpenditureType ExpenditureTypeId { get; set; }
       // [Column(TypeName="decimal(18,2)")]
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}