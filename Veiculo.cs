namespace ExercicioPOO
{
    public class Veiculo
    {
        public int Velocidade { get; private set; }

        public void AlterarVelocidade(int velocidade)
        {
            Velocidade = velocidade;
            if (Velocidade >= 0 && Velocidade <= 200)
            {
                Console.WriteLine($"A velocidade do veículo é: {Velocidade}Km/h.");
            }
            else
            {
                Console.WriteLine($"A velocidade não pode ser: {Velocidade}Km/h, pois, é inválida.");
            }
        }
    }
}