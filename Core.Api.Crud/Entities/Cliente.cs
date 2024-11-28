using System.ComponentModel.DataAnnotations;
namespace Core.Api.Crud.Entities
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string nombre { get; set; }


        [Range(1,100,ErrorMessage ="La edad debe estar entre 1 y 100")]
        public int edad { get; set; }

 
        [EmailAddress(ErrorMessage ="Email Invalido")]
        public string email { get; set; }
       
    }
}
