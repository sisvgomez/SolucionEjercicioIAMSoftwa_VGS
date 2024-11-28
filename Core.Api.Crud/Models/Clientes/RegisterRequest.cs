using System.ComponentModel.DataAnnotations;

namespace Core.Api.Crud.Models.Clientes
{
    public class RegisterRequest
    {
        [Required]
        public string nombre { get; set; }

        [Required]
        public int edad { get; set; }

        [Required]
        public string email { get; set; }

    }
}
