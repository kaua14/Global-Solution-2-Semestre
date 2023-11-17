using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_prescricao_medica
    {
        [Key]
        public int IdPrescricao { get; set; }

        [Range(0, 100)]
        public string Medicamento { get; set; }

        [Range(0, 50)]
        public string dosagem { get; set; }

        [Range(0, 255)]
        public string instrucoes { get; set; }

        public DateTime? dataPrescricao { get; set; }
    }
}
