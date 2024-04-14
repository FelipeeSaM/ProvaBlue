using ProvaBlue.Db;
using ProvaBlue.Models;
using ProvaBlue.Repository.Generic;

namespace ProvaBlue.Business.Implementations {
    public class ContatoBusinessImplementations : IContatoBusiness {

        private readonly IGenericRepository<ContatoModel> _context;

        public ContatoBusinessImplementations(IGenericRepository<ContatoModel> context) {
            _context = context;
        }

        public async Task<List<ContatoModel>> ListarTodosContatos() {
            return await _context.FindAll();
        }

        public async Task<ContatoModel> ListarPorId(int id) {
            var contact = _context.FindById(id);
            if(contact == null) {
                return null;
            }
            return contact;
        }

        public async Task<ContatoModel> CriarContato(ContatoModel contato) {
            return await _context.Create(contato);
        }

        public async Task<ContatoModel> ModificarContato(ContatoModel contato) {
            await _context.Update(contato);
            return contato;
        }

        public void DeletarContato(int id) {
            _context.Delete(id);
        }

    }
}
