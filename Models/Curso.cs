using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace atendimento_aluno.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Descricao { get; set; }
    }
}
