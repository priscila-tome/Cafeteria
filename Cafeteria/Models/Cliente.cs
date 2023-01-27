using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafeteria.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cpf")]
        [Column("Cpf")]
        public string cpfCliente { get; set; }

        [Display(Name = "Email")]
        [Column("emailCliente")]
        public string emailCliente { get; set; }

        [Display(Name = "Senha")]
        [Column("senhaCliente")]
        public string senhaCliente { get; set; }
    }
}
