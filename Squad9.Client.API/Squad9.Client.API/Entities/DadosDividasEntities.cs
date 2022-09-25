using System.ComponentModel.DataAnnotations.Schema;

namespace Squad9.Client.API.Entities
{
    [Table("Dividas")]
    public class DadosDividasEntities
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Valor")]
        public double Valor { get; set; }

        [Column("Financeira")]
        public string Financeira { get; set; }

        [Column("Juros")]
        public double Juros { get; set;  }

        [Column("Data")]
        public DateTime Data { get; set; }

        [Column("DataDivida")]
        public DateTime DataDivida { get; set; }

        [Column("Contrato")]
        public string Contrato { get; set; }
    }
}
