using Core.Api.Crud.Entities;
using Core.Api.Crud.Models.Clientes;
using Core.Api.Crud.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.Api.Crud.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private IClienteService _clienteService;



        public ClientesController(IClienteService Clienteservice)
        {
            _clienteService = Clienteservice;

        }


        [HttpPost("register")]

        public IActionResult Register(Cliente model)
        {
       
                _clienteService.Register(model);
                return Ok(new { message = "Registro exitoso" });
           
            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Customers = _clienteService.GetAll();
            return Ok(Customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _clienteService.GetById(id);
            return Ok(customer);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateRequest model)
        {
            _clienteService.Update(id, model);
            return Ok(new { message = "Usuario actualizado con éxito" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clienteService.Delete(id);
            return Ok(new { message = "Usuario eliminado con éxito" });

        }
    }
}
