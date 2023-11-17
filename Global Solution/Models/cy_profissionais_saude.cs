using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Global_Solution.Models
{
    public class cy_profissionais_saude
    {
        [Key]
        public int IdProfissional { get; set; }

        public virtual ICollection<cy_usuarios> IdUsuario { get; set; }


        [Range(0,100)]
        public string especialidade { get; set; }

        [Range(0,50)]
        public string RegistroMedico { get; set; }
        
    }
}
