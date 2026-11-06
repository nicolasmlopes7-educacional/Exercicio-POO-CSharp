namespace ExercicioPOO
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; private set; }

        public void DefinirSalario(decimal salario)
        {
            Salario = salario;
        }
        public void AumentarSalario(decimal adicional)
        {
            decimal salarioAtualizado = ((1 + (adicional / 100)) * Salario);
            Salario = salarioAtualizado;
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"O salario do funcionário {Nome}, de cargo {Cargo}, é {Salario:C}");
        }
    }
}