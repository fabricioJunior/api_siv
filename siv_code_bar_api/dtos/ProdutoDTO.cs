namespace siv_code_bar_api.models
{
    public class ProdutoDTO
    {

        public string CodigoDeBarras { get; set; }
        public string CodigoReduzido { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public Referencia Referencia { get; set; }

        public ProdutoDTO(
            string codigoDeBarras,
            string codigoReduzido,
            string tamanho,
            string cor,
            Referencia referencia
            )
        {

            CodigoDeBarras = codigoDeBarras;
            CodigoReduzido = codigoReduzido;
            Tamanho = tamanho;
            Cor = cor;
            Referencia = referencia;
        }
    }
}

