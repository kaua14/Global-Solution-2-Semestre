using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }

        public string TipoConsulta { get; set; }

        public string NomeConsulta { get; set; }

      
    }
}
