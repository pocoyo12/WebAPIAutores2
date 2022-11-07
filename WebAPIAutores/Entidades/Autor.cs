using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAPIAutores.Validacion;

namespace WebAPIAutores.Entidades
{
    public class Autor: IValidatableObject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        //[PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        //[Range (18, 120)]
        //[NotMapped]
        //public int edad { get; set; }
        //[CreditCard]
        //[NotMapped ]
        //public string CreditCard { get; set; }
        //[Url]
        //public string Url { get; set; }
        //public int menor { get; set; }
        //public int mayor { get; set; }
        public List<Libro> Libros { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(!string.IsNullOrEmpty(Nombre))
            {
                var primeraletra = Nombre[0].ToString();

                if( primeraletra != primeraletra.ToUpper())
                {
                    yield return new ValidationResult("LA p[rimera letra debe ser mayuscula",
                        new string[] { nameof(Nombre) });
                }
            }
            //if(menor > mayor)
            //{
            //    yield return new ValidationResult("El valor de campo no puede ser mayor que el campo mayor",
            //        new[] { nameof(menor) });

            //}
        }
    }
}
