namespace Modelo_Relacional.Data.Entities;
using System.ComponentModel.DataAnnotations;

    public class City
    {
        public int Id { get; set; }
    [Display(Name = "Ciudad")]
    [MaxLength(50, ErrorMessage = "El campo {0} excede el máximo de caracteres")]
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string Name { get; set; }
    }

