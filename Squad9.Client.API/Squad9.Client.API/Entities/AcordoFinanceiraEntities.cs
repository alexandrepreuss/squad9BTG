using System.ComponentModel.DataAnnotations.Schema;

namespace Squad9.Client.API.Entities
{
    [Table("Financeiras")]
    public class AcordoFinanceiraEntities
    {
        [Column("Nome")]
        public string Financeira { get; set; }

        [Column("Contrato")]
        public string Contrato { get; set; }

        [Column("DAta")]
        public DateTime Data { get; set; }
    }
}
