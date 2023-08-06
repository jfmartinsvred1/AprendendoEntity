namespace Program
{
    public class Cliente
    {
        public Cliente() 
        {
            DataDeCadastro=DateTime.Now;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public GerarNota Notas { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}