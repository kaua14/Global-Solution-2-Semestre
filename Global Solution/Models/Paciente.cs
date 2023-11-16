using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Cpf { get; set; }

    }
}
