using ProvaBlue.Models;

namespace ProvaBlue.Business {
    public interface IContatoBusiness {
        Task<List<ContatoModel>> ListarTodosContatos();
        Task<ContatoModel> ListarPorId(int id);
        Task<ContatoModel> CriarContato(ContatoModel contato);
        Task<ContatoModel> ModificarContato(ContatoModel contato);
        void DeletarContato(int id);
    }
}
