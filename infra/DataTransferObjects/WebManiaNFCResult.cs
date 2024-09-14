using System;
namespace infra.RemoteDataAccess
{
	public class WebManiaNFCResult
	{
        public WebManiaNFCResult(string uuid, string status, string motivo, string nfe, string serie, string modelo, bool epec, string recibo, string chave, string xml, string danfe, string danfe_simples, string danfe_etiqueta)
        {
            this.Uuid = uuid;
            this.Status = status;
            this.Motivo = motivo;
            this.Nfe = nfe;
            this.Serie = serie;
            this.Modelo = modelo;
            this.Epec = epec;
            this.Recibo = recibo;
            this.Chave = chave;
            this.Xml = xml;
            this.Danfe = danfe;
            this.DanfeSimples = danfe_simples;
            this.DanfeEtiqueta = danfe_etiqueta;
        }

        public string Uuid { get; set; }
        public string Status { get; set; }
        public string Motivo { get; set; }
        public string Nfe { get; set; }
        public string Serie { get; set; }
        public string Modelo { get; set; }
        public bool Epec { get; set; }
        public string Recibo { get; set; }
        public string Chave { get; set; }
        public string Xml { get; set; }
        public string Danfe { get; set; }
        public string DanfeSimples { get; set; }
        public string DanfeEtiqueta { get; set; }


	}
}

