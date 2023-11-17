using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_notificacoes
    {
        [Key]
        public int IdNotificacao { get; set; }

        [Range(0, 255)]
        public string mensagem { get; set; }

        public DateTime? dataEnvio { get; set; }

        public bool lida { get; set; }
    }
}
