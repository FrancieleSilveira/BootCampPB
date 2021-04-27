namespace ArquivoBaseBootcamp.Services
{
    public interface IBootCampServices
    {
        public string ConsultarInteressada();
        public string ConsultarTodasInteressadas();
        public string CadastrarInteressada();
        public string AtualizarInteressada();
        public bool ExcluirInteressada();
    }
}
