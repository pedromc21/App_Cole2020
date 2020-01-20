using System;

namespace App_Cole2020.Common.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Debt
    {
        //Id, LLaveRef, Persona_Id, IdCiclo, Plantel, Concepto, Total, Recargo, Abono, Saldo, FechaVencimiento
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LLaveRef { get; set; }
        [Key, Column(Order = 1)]
        public int Persona_Id { get; set; }
        [Key, Column(Order = 2)]
        public int IdCiclo { get; set; }
        [Key, Column(Order = 3)]
        public int Mes { get; set; }
        [Required]
        public string Plantel { get; set; }
        [Required]
        public string Concepto { get; set; }
        public Decimal Total { get; set; }
        public Decimal Recargo { get; set; }
        public Decimal Abono { get; set; }
        public Decimal Saldo { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public virtual Student Student { get; set; }
    }
}
