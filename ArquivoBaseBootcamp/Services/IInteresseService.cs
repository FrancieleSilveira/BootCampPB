using System.Collections.Generic;

namespace ArquivoBaseBootcamp.Services
{
    public interface IInteresseService
    {
        public object ConsultarPorEmail();
        public List<object> ConsultarTodos();
        public object Incluir();
        public object AtualizarEmail();
        public bool ExcluirPorEmail();
    }
}
