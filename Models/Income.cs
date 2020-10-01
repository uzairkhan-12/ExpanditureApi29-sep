using System.ComponentModel.DataAnnotations.Schema;

namespace ExpanditureApi.Models {
    public class Income {
        public int Id {get ; set ;}
        [Column(TypeName = "decimal(18, 2)")]
        public decimal amount { get ; set ;}
    }
}