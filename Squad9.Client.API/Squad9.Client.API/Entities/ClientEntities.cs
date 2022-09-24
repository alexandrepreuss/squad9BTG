using Squad9.Client.API.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Squad9.Client.API.Entities
{
    [Table("Clientes")]
    public class ClientEntities
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("CPf")]
        public string CPF { get; set; }

        [Column("Histórico")]
        public HistoricoModel Historico { get; set; }
    }
}
