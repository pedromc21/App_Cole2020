namespace App_Cole2020.Common.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Tutor
    {
        //Id, Persona_Id, Clave_Familia, Apellido_Paterno, Apellido_Materno, Nombres, Parentesco, Tutor_Principal
        [Key]
        public int Tutor_Id { get; set; }
        [Required]
        public string Clave_Familia { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombres { get; set; }
        public string Parentesco { get; set; }
        public bool Tutor_Principal { get; set; }

        //public Student Student { get; set; }
    }
}
