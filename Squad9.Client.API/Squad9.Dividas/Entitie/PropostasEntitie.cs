using System.ComponentModel.DataAnnotations.Schema;

namespace Squad9.Entidade.API.Entitie
{
    [Table("Propostas")]
    public class PropostasEntitie
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Juros")]
        public double Juros { get; set; }

        [Column("Data")]
        public DateTime Data { get; set; }

        [Column("Valor")]
        public double Valor { get; set; }

        [Column("Parcelas")]
        public int Parcelas { get; set; }

        [Column("TotalDivida")]
        public double TotalDivida { get; set; }
    }
}
