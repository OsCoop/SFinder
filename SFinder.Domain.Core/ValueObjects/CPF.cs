namespace SFinder.Domain.Core.ValueObjects
{
    public class Cpf
    {
        public string Valor { get; private set; }

        public bool CadastrarCpf(string cpf)
        {

            Valor = cpf;
            return true;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
