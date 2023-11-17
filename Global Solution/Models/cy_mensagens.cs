using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_mensagens
    {
        [Key]
        public int idMensagem { get; set; }

        public int Remetente { get; set; }

        public int Destinatario { get; set; }

        [Range(1, 255)]
        public string Mensagem { get; set; }

        public DateTime? dataEnvio { get; set; }

        public bool lida { get; set; }
    }
}
