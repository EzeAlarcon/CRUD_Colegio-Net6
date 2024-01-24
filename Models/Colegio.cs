using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Colegio.Models
{
    public class Colegio
    {
        // Identificador único del estudiante
        public int Id { get; set; }

        // Nombre del estudiante
        [MaxLength(50, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is required.")]
        public string Name { get; set; } = null!;

        // Grado del estudiante
        [MaxLength(50, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        [Required(ErrorMessage = "The field {0} is required.")]
        public string GradeLevel { get; set; } = null!;

        // Curso del estudiante
        [DataType(DataType.MultilineText)]
        [Display(Name = "Course")]
        [MaxLength(500, ErrorMessage = "The field {0} must have a maximum of {1} characters.")]
        public string Course { get; set; } = null!;

        // Calificación del estudiante
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "The field {0} is required.")]
        public decimal Grade { get; set; }
    }
}