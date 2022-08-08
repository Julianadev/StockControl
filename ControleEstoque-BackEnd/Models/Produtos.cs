using System.ComponentModel.DataAnnotations;

namespace ControleEstoque_BackEnd.Models
{
    public class Produtos : ProdutosBase
    {
        [Required]
        [StringLength(8)]
    }

}





