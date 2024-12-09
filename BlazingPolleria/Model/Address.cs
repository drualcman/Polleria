using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Este campo no puede estar vacío"), MinLength(3, ErrorMessage = "Por favor, usa un nombre con más de 3 letras."), MaxLength(100, ErrorMessage = "Por favor, usa un nombre con menos de 100 letras.")]
        public string Name { get; set; }

        [Required (ErrorMessage ="Este campo no puede estar vacío"), MinLength(5, ErrorMessage = "Por favor, usa una dirección con más de 5 letras."), MaxLength(100, ErrorMessage = "Por favor, usa una dirección con menos de 100 letras.")]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required (ErrorMessage = "Este campo no puede estar vacío"), MinLength(3, ErrorMessage = "Por favor, usa una ciudad con más de 3 letras."), MaxLength(50, ErrorMessage = "Por favor, usa una ciudad con menos de 50 letras.")]
        public string City { get; set; }

        [Required (ErrorMessage = "Este campo no puede estar vacío"), MinLength(3, ErrorMessage = "Por favor, usa una región con más de 3 letras."), MaxLength(20, ErrorMessage = "Por favor, usa una región con menos de 20 letras.")]
        public string Region { get; set; }

        [Required (ErrorMessage = "Este campo no puede estar vacío"), RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Por favor, usa un código postal válido con cinco números.")]
        public string PostalCode { get; set; }
    }

}
