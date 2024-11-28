using System.ComponentModel.DataAnnotations;

namespace BlazorAppCrud.Models
{
    public class EditCliente
    {
        [Required]
        public string nombre { get; set; }

        [Required]
        public int edad { get; set; }

        [Required]
        public string email { get; set; }

      

        public EditCliente() { }

        public EditCliente(Cliente cliente) {
        
            nombre = cliente.nombre;
            edad = cliente.edad;
            email = cliente.email;
          
        }

    }
}
