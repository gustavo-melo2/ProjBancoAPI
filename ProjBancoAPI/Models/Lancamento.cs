using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjBancoAPI.Models
{
    [Table("Tbl_Lancamento")]
    public class Lancamento
    {
        [Column("Id"), Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Column(TypeName = "date"),Required, DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public int? ExtratoId { get; set; }
    }
}