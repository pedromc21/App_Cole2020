namespace App_Cole2020.Common.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Group
    {
        //Grupo_Id, Persona_Id, Clave, NameGrupo, TipoGrupo
        [Key, Column(Order = 0), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Grupo_Id { get; set; }
        
        [Key, Column(Order = 1)]
        public int Persona_Id { get; set; }
        
        [Required]
        public string Clave { get; set; }
        [Required]
        public string NameGrupo { get; set; }
        public string TipoGrupo { get; set; }

        public virtual Student Student { get; set; }
    }
}
