namespace App_Cole2020.Common.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    public class Student
    {
        //Persona_Id, Clave_Plantel, Plantel, Matricula, Clave_Familia, Apellido_Paterno, Apellido_Materno, Nombres, Nivel, Grado, Grupo
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Persona_Id { get; set; }
        [Key, Column(Order = 1)]
        public string Clave_Familia { get; set; }
        public string Clave_Plantel { get; set; }
        public string Plantel { get; set; }
        [Required]
        public string Matricula { get; set; }
        [Required]
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombres { get; set; }
        public string Nivel { get; set; }
        public string Grado { get; set; }
        public string Grupo { get; set; }

        //public ICollection<Tutor> ClaveFamilia { get; set; }
    }
}
