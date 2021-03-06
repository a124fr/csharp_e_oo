namespace ByteBank.Modelos.Funcionarios
{
    public class Designer : Funcionario
    {
        // 3000,00
        public Designer(string cpf)
            : base(3000.0, cpf)
        {}

        public override void AumentarSalario()
        {
            Salario *= 1.11; 
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
