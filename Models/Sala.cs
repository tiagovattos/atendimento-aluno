using System.ComponentModel.DataAnnotations;

namespace atendimento_aluno.Models
{
    public class Sala
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public String Descricao { get; set; }

        public int Equipamentos { get; set; }

        [Required]
        [StringLength(1)]
        public char Situacao { get; set; }
    }
}