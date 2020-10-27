using System;
using System.Collections.Generic;

namespace ExpanditureApi.Models
{
    public class ExpenditureType
    {
        public int Id { get; set; }
        public List<Expanditure> Expanditures { get; set; }
        public string ExpenditureTypeName { get; set; }
        public DateTime AddedOn { get; set; }
        public bool IsActive { get; set; }
    }
}