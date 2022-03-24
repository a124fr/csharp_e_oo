namespace ByteBank.Modelos
{
    public interface IAutenticavel
    {
        string Senha { get; set; }

        bool Autenticar(string senha);
    }
}
