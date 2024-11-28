using BlazorAppCrud.Models;
using System.ComponentModel.Design;

namespace BlazorAppCrud.Services
{
    public interface IClienteService
    {
        Cliente cliente { get; }
        

        Task Register(AddCliente model);
        Task<IList<Cliente>> GetAll();
        Task<Cliente> GetById(int id);
        Task Update(int id, EditCliente model);
        Task Delete(int id);
    }
    public class ClienteService : IClienteService
    {
        private IHttpService _httpService;



        public Cliente cliente { get; private set; }
        public ClienteService(
            IHttpService httpService


        )
        {
            _httpService = httpService;


        }



        public async Task Register(AddCliente model)
        {
            await _httpService.Post("/clientes/register", model);
        }

        public async Task<IList<Cliente>> GetAll()
        {
            return await _httpService.Get<IList<Cliente>>("/clientes");
        }

        public async Task<Cliente> GetById(int id)
        {
            return await _httpService.Get<Cliente>($"/clientes/{id}");
        }

        public async Task Update(int id, EditCliente model)
        {
            await _httpService.Put($"/clientes/{id}", model);


            if (id == cliente.id)
            {
                 
                cliente.nombre = model.nombre;
                cliente.edad = model.edad;
                cliente.email= model.email;
          

            }
        }

        public async Task Delete(int id)
        {
            await _httpService.Delete($"/clientes/{id}");


        }
    }
}
