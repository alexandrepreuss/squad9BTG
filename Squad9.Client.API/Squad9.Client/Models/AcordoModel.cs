using System.ComponentModel.DataAnnotations.Schema;

namespace Squad9.Client.Front.Models
{
    public class AcordoModel
    {
        [Table("Acordo")]
        public class AcordoFinanceiraEntities
        {
            [Column("Id")]
            public string IdAcordo { get; set; }

            [Column("Nome")]
            public string Financeira { get; set; }

            [Column("Contrato")]
            public string Contrato { get; set; }

            [Column("Data")]
            public DateTime Data { get; set; }

            [Column("Juros")]
            public string Juros { get; set; }

            [Column("Prazo")]
            public string Prazo { get; set; }
        }
    }
}
