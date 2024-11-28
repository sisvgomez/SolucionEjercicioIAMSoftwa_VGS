using System.ComponentModel.DataAnnotations;

namespace BlazorAppCrud.Models
{
    public class AddCliente
    {
        [Required]
        public string nombre { get; set; }

        [Required]
        public int edad { get; set; }

        [Required]
        public string email { get; set; }

    }
}
