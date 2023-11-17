using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_hospitais
    {
        [Key]
        public int IdHospital { get; set; }

        [Range(0, 100)]
        public string nomeHospital { get; set; }

        [Range(0, 255)]
        public string endereco { get; set; }

        [Range(0, 255)]
        public string cidade { get; set; }

        [Range(0, 255)]
        public string estado { get; set; }

        [Range(0, 10)]
        public string cep { get; set; }

        [Range(0, 20)]
        public string telefone { get; set; }
    }
}
