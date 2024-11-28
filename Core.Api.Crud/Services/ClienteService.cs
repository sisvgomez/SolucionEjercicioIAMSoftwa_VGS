using Core.Api.Crud.Data;
using Core.Api.Crud.Entities;
using Core.Api.Crud.Helpers;
using Core.Api.Crud.Models.Clientes;

namespace Core.Api.Crud.Services
{
    public class ClienteService:IClienteService
    {
        private DataContext _context;
     

        public ClienteService(DataContext context)
        {
            _context = context;
      
        }

   

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes;
        }

        public Cliente GetById(int id)
        {
            return GetCliente(id);
        }

        public void Register(Cliente model)
        {
            //// validate
            //if (_context.Clientes.Any(x => x.rfc == model.rfc))
            //    throw new AppException("rfc '" + model.rfc + "' ya existe");
        
            // save Customer
            _context.Clientes.Add(model);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateRequest model)
        {
            var customer = GetCliente(id);

       
            //if (model.rfc != customer.rfc && _context.Clientes.Any(x => x.rfc == model.rfc))
            //    throw new AppException("rfc '" + model.rfc + "' ya existe");

        
            customer.nombre = model.nombre;
            customer.edad=model.edad;
            customer.email = model.email;
        
            _context.Clientes.Update(customer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var Customer = GetCliente(id);
            _context.Clientes.Remove(Customer);
            _context.SaveChanges();
        }

       

        private Cliente GetCliente(int id)
        {
            var Cliente = _context.Clientes.Find(id);
            if (Cliente == null) throw new KeyNotFoundException("Cliente no Encontrado");
            return Cliente;
        }

    }
}
