using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommifyInterview.Entities
{
    public class TaxBand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Threshold { get; set; }
        public int TaxPercentage { get; set; }
    }
}
