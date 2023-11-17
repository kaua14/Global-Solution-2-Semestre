using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_historico_medico
    {
        [Key]
        public int IdHistorico { get; set; }



        public DateTime? dataEvento { get; set; }

        [Range(0, 255)]
        public string descricao { get; set; }

        [Range(0, 255)]
        public string Notas { get; set; }
    }
}
