using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_consulta_medica
    {
        [Key]
        public int IdConsulta { get; set; }

        public DateTime? dataConsulta { get; set; }

        [Range(0, 255)]
        public string sintomas { get; set; }

        [Range(0, 255)]
        public string descricao { get; set; }

        [Range(0, 255)]
        public string diagnostico { get; set; }

        [Range(0, 255)]
        public string prescricao { get; set; }

        [Range(0, 20)]
        public string status { get; set; }
    }
}
