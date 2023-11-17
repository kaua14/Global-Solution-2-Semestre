using System.ComponentModel.DataAnnotations;

namespace Global_Solution.Models
{
    public class cy_pagamentos
    {
        [Key]
        public int IdPagamento { get; set; }

        public virtual ICollection<cy_consulta_medica> IdConsulta { get; set; }

        public float valor { get; set; }

        public DateTime dataPagamento { get; set; }

        [Range(0,20)]
        public string status { get; set; }

        [Range(0,255)]
        public string informacoesCartao { get; set; }

    }
