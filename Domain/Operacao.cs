using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("OperacoesHistoricos")]
    public class Operacao
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("nome_Operacao")]
        public string? Nome {get; set; }

        [Column("resultado")]
        public float Valor { get; set; }

        [Column("data")]
        public DateTime Data { get; set; }

        public Operacao(string? nome, float valor, DateTime data)
        {
            Nome = nome;
            Valor = valor;
            Data = data;
        }
    }
}
