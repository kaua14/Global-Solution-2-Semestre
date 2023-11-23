using Microsoft.EntityFrameworkCore;

namespace Global_Solution.Models
{
    public class OracleDBContext : DbContext
    {
        public DbSet<cy_consulta_medica> cy_ConsultaMedica { get; set; }
        public DbSet<cy_especialidade_medica> cy_EspecialidadesMedicas { get; set; }
        public DbSet<cy_feedbacks> cy_Feedbacks { get; set; }
        public DbSet<cy_historico_medico> cy_HistoricoMedico { get; set; }
        public DbSet<cy_hospitais> cy_Hospitais { get; set; }
        public DbSet<cy_mensagens> cy_Mensagens { get; set; }
        public DbSet<cy_notificacoes> cy_Notificacoes { get; set; }
        public DbSet<cy_pagamentos> cy_Pagamentos { get; set; }
        public DbSet<cy_prescricao_medica> cy_PrescricoesMedicas { get; set; }
        public DbSet<cy_profissionais_saude> cy_ProfissionaisSaude { get; set; }
        public DbSet<cy_usuarios> cy_Usuarios { get; set; }

        public OracleDBContext(DbContextOptions<OracleDBContext> options) : base(options)
        {

        }
    }
}


