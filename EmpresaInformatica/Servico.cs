using EmpresaInformatica;

namespace Program
{
   public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public IList<GerarNotasServicos> Notas { get; set; }
        public DateTime DataDeEntrega { get; set; }
        public string Descricao { get; set; }
    }
}