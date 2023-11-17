using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_profissionais_saude
    {
        [Key]
        public int IdProfissional { get; set; }
        [Range(0,100)]
        public string especialidade { get; set; }

        [Range(0,50)]
        public string RegistroMedico { get; set; }
        
    }
}
