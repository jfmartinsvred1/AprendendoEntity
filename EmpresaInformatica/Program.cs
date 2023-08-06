using EmpresaInformatica;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            IncluiGerarNota();
        }

        public static void IncluiServico()
        {
            Servico manuntencao = new Servico()
            {
                Nome = "Manutenção",
                Valor = 150,
                Descricao = "Limpeza inclusa,Otimizacao Inclusa E Formatacao Com Windows 10 Incluso.",
                DataDeEntrega = DateTime.Now.AddDays(3)
            };
            using (var c = new InformaticaContext())
            {
                c.Servicos.Add(manuntencao);
                c.SaveChanges();
            }
        }
        public static void IncluiCliente()
        {
            Cliente cliente = new Cliente() { };
            Console.Write("Digite O Nome Do Novo Cliente: ");
            cliente.Nome = Console.ReadLine();
            using (var c = new InformaticaContext())
            {
                c.Clientes.Add(cliente);
                c.SaveChanges();
            }
        }
        //public static void IncluiGerarNota()
        //{
        //    Servico s1 = new Servico() ;
        //    s1.Valor = 150;
        //    s1.Descricao = "gfgfdg";
        //    s1.Nome = "gfdgg";
        //    Servico s2 = new Servico();
        //    s2.Valor = 1530;
        //    s2.Descricao = "gfgfdfgfg";
        //    s2.Nome = "gfdggfgfg";
        //    Servico s3 = new Servico();
        //    s3.Valor = 1550;
        //    s3.Descricao = "gfgfdg";
        //    s3.Nome = "gfdgg";
            
        //    GerarNota n1 = new GerarNota() { };
            
        //    n1.IncluiServicoss(s1);
        //    double valor = +n1.GetValorTot();
        //    n1.IncluiServicoss(s2);
        //    valor = +n1.GetValorTot();
        //    n1.IncluiServicoss(s3);
        //    valor = +n1.GetValorTot();
        //    n1.Valor = valor;
        //    using (var c = new InformaticaContext())
        //    {
        //        Cliente cc = c.Clientes.Where(c => c.Id==8).First();
        //        n1.Cliente = cc;
        //        c.Notas.Add(n1);
        //        c.SaveChanges();
        //    }
            
        ////}
        ////public static void ListarNotas()
        ////{
        ////    using(var c = new InformaticaContext()) 
        ////    {
        ////        IList<GerarNota> nots = c.Notas.ToList();
        ////    }
        //}

    }
}