using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_feedbacks
    {
        [Key]
        public int IdFeedback { get; set; }

        [Range(0, 255)]
        public string comentario { get; set; }

        public int classificacao{ get; set; }
    }
}
