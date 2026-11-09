namespace ExercicioPOO
{
    public class Calculadora
    {
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine($"O resultado da soma é: {resultado}.");
        }
        public void Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            Console.WriteLine($"O resultado da subtração é: {resultado}.");
        }
        public void Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}.");
        }

        public static void Dividir(int num1, int num2)
        {
            if (num2 > 0)
            {
                int resultado = num1 / num2;
                Console.WriteLine($"O resultado da divisão é: {resultado}.");
            }
            else
            {
                Console.WriteLine("Não pode ser efetuado está conta!");
            }
        }
    }
}