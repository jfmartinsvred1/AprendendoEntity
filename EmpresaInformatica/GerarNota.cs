using EmpresaInformatica;

namespace Program
{
    public class GerarNota
    {
        public GerarNota() 
        {

            
            DataGerada=DateTime.Now;
            this.Servico = new List<GerarNotasServicos>();
        }
        public int Id { get; set; }
        public DateTime DataGerada { get; set; }
        public double Valor { get; set; }
        public IList<GerarNotasServicos> Servico { get; set; }
        public void IncluiServicoss(Servico servico)
        {
            this.Servico.Add(new GerarNotasServicos() { Servico = servico });
        }
        public double GetValorTot()
        {
            double valor = 0;
            foreach(var item in Servico)
            {
                valor = item.Servico.Valor;
            }
            return valor;
        }
    }
}