using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafeteria.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nomeProduto")]
        public string nomeProduto { get; set; }

        [Display(Name = "Descrição")]
        [Column("descricaoProduto")]
        public string descricaoProduto { get; set; }

        [Display(Name = "Valor")]
        [Column("valorProduto")]
        public string valorProduto { get; set; }

    }
}