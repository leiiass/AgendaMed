using AgendaMed.Dominio.Enums;

namespace AgendaMed.Dominio.Modelos
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoEstabelecimento Tipo { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string CNPJ { get; set; }
    }
}
