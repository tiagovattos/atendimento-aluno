using System.ComponentModel.DataAnnotations;

namespace atendimento_aluno.Models
{
    public class Atendimento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Aluno Aluno { get; set; }

        [Required]
        public Sala Sala { get; set; }

        [Required]
        public String DataAtendimento { get; set; }

        [Required]
        public String HoraAtendimento { get; set; }
    }
}
