using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaInformatica
{
    public class GerarNotasServicos
    {
        public int NotaId { get; set; }
        public GerarNota Nota { get; set; }
        public int ServicoID { get; set; }
        public Servico Servico { get; set; }
        
    }
}
