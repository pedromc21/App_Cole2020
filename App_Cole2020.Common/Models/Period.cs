namespace App_Cole2020.Common.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Period
    {
        //Id, Periodo_Id, Ciclo_Escolar
        [Key]
        public int Periodo_Id { get; set; }
        [Required]
        public string Ciclo_Escolar { get; set; }
    }
}
