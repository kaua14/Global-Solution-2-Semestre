using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }

        public bool Disponibilidade { get; set; }

        public string Hospital { get; set; }
    }
}
