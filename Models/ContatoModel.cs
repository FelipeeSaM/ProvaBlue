using ProvaBlue.Models.Base;

namespace ProvaBlue.Models {
    public class ContatoModel : BaseModel {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Numero { get; set; }
    }
}
