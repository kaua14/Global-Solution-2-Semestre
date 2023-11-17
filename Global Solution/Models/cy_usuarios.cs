using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        [Range(0, 100)]
        public string nome { get; set; }

        [Range(0, 255)]
        public string email { get; set; }

        [Range(0, 255)]
        public string senha { get; set; }

        public DateTime? dataNascimento { get; set; }

        public bool sexo { get; set; }

    }
}
