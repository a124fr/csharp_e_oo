namespace ByteBank.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        // 4000,00
        public GerenteDeConta(string cpf) 
            : base(4000.0, cpf)
        {}

        public override void AumentarSalario()
        {
            Salario *= 1.05; 
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
