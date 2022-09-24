using System.ComponentModel.DataAnnotations.Schema;

namespace Squad9.Dividas
{
    [Table("Entidades")]
    public class EntidadeEntitie
    {
        [Column("Nome")]
        public string Name { get; set; }

        [Column("IdBanco")]
        public int IdBanco { get; set; }

        [Column("Certificado")]
        public byte[] Certificado{get; set;}

    }
}