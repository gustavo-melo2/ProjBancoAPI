using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjBancoAPI.Models
{
    [Table("Tbl_Cartao")]
    public class Cartao
    {
        [Column("Id"), Key]
        public int Id { get; set; }

        [Required]
        public TipoCartao Tipo { get; set; }

        public Extrato Extrato { get; set; }

        public int? ExtratoId { get; set; }
    }
}
