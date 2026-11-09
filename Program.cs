using System.Reflection.Metadata;
using ExercicioPOO;

//! Ex1:
Pessoa p1 = new Pessoa();
p1.Nome = "Nicolas";
p1.Idade = 17;
p1.Cidade = "São Paulo";

p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Alisson";
p2.Idade = 17;
p2.Cidade = "Diadema";

p2.Apresentar();

//! Ex2:
// Calculadora c1 = new Calculadora();
// c1.Somar(4, 2);
// c1.Subtrair(4, 2);
// c1.Multiplicar(4, 2);
// Calculadora.Dividir(4, 2);

//! Ex3
// Veiculo mustang = new Veiculo();
// mustang.AlterarVelocidade(0);

//! Ex4
// Funcionario nicolas = new Funcionario();
// nicolas.Nome = "Nicolas";
// nicolas.Cargo = "Programador";
// nicolas.DefinirSalario(1000);
// nicolas.AumentarSalario(10);
// nicolas.ConsultarSalario();

//! Ex5
// Livro l1 = new Livro();
// l1.Exibir();
// Livro l2 = new Livro("Paixão segundo G.H.");
// l2.Exibir();
// Livro l3 = new Livro("Noites Brancas", "Fiódor Dostoiévski");
// l3.Exibir();
// Livro l4 = new Livro("Memórias do Subsolo", "Fiódor Dostoiévski", 184);
// l4.Exibir();