using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjBancoAPI.Models
{
    [Table("Tbl_Extrato")]
    public class Extrato
    {
        [Column("Id"), Key]
        public int ExtratoId { get; set; }

        [Required]
        public decimal SaldoAtual { get; set; }

        public ICollection<Lancamento> Lancamentos { get; set; }
    }
}