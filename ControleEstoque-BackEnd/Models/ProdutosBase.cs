using System.ComponentModel.DataAnnotations;

namespace ControleEstoque_BackEnd.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Produtos")]
    public class ProdutosBase
    {
        public int Id { get; set; }
        [Required]
        [StringLength(6)]
        public string Nome { get; set; }
        [Required]
        [StringLength(20)]
        public string Tipo { get; set; }
        [Required]
        [StringLength(20)]
        public string Validade { get; set; }
    }
}