using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_especialidade_medica
    {
        [Key]
        public int IdEspecialidade { get; set; }

        [Range(0,100)]
        public string nomeEspecialidade { get; set; }
    }
}
