namespace RenoEnergy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("alumnos")]
    public partial class alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alumno()
        {
            asistencias = new HashSet<asistencia>();
        }

        [Key]
        public int IDAlumno { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(60)]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [StringLength(100)]
        public string apellidos { get; set; }

        [Required]
        [Display(Name = "Universidad")]
        [StringLength(75)]
        public string universidad { get; set; }

        [Required]
        [Display(Name = "Carrera")]
        [StringLength(100)]
        public string carrera { get; set; }
        [Display(Name = "Matricula")]
        [Range(1, 999999999999, ErrorMessage = "Rating must between 1 to 10")]
        public int matricula { get; set; }

        [Required]
        [Display(Name = "Correo")]
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string correo { get; set; }
        [Display(Name = "Fecha de registro")]
        public DateTime? fechareg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asistencia> asistencias { get; set; }
    }
}
