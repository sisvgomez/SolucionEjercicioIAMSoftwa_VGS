using System.ComponentModel.DataAnnotations;

namespace Core.Api.Crud.Models.Clientes
{
    public class UpdateRequest
    {
         
        public string nombre { get; set; }

         
        public int edad { get; set; }

      
        public string email { get; set; }

    
     
    }
}
