using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendimento_aluno.Models
{
    public enum Periodo
    {
        Manha,
        Tarde,
        Noite
    }

    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        public String DataNascimento { get; set; }

        public Curso Curso { get; set; }

        public Periodo Periodo { get; set; }
    }
}
