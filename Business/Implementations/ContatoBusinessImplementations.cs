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
            try {
                return await _context.FindAll();
            }
            catch(Exception) {

                throw;
            }
        }

        public async Task<ContatoModel> ListarPorId(int id) {
            try {
                var contact = await _context.FindById(id);
                if(contact == null) {
                    return null;
                }
                return contact;
            }
            catch(Exception) {

                throw;
            }
        }

        public async Task<ContatoModel> CriarContato(ContatoModel contato) {
            try {
                return await _context.Create(contato);
            }
            catch(Exception) {

                throw;
            }
        }

        public async Task<ContatoModel> ModificarContato(ContatoModel contato) {
            try {
                await _context.Update(contato);
            }
            catch(Exception) {

                throw;
            }
            return contato;
        }

        public void DeletarContato(int id) {
            try {
                _context.Delete(id);
            }
            catch(Exception) {

                throw;
            }
        }

    }
}
