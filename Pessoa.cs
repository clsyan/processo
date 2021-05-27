namespace processoagil {
    public enum Empresa {
        Dogehouse,
        CodeMiner42,
        PiedPiper,
    }
    public class Pessoa{
        public string Nome { get; set; }
        public Empresa Empresa { get; set; } = Empresa.Dogehouse;
        public string Cpf { get; set; }
    }
    
}