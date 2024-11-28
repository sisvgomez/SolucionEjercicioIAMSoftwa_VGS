
using Core.Api.Crud.Entities;
using Core.Api.Crud.Models.Clientes;

namespace Core.Api.Crud.Services
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);
        void Register(Cliente model);
        void Update(int id, UpdateRequest model);
        void Delete(int id);
    }
}
