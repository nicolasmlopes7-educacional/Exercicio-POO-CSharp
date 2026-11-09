namespace ExercicioPOO
{
    public class Livro
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "O jogador";
            Autor = "Fiódor Dostoiévski";
            NumeroPaginas = 232;
        }
        public Livro(string tituloLivro)
        {
            Titulo = tituloLivro;
        }
        public Livro(string tituloLivro, string autor)
        {
            Titulo = tituloLivro;
            Autor = autor;
        }
        public Livro(string tituloLivro, string autor, int numeroPaginas)
        {
            Titulo = tituloLivro;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
        }
        public void Exibir()
        {
            var texto = $"Título: {Titulo}";
            if (Autor != null)
                texto += $", Autor(a): {Autor}";
            if (NumeroPaginas > 0)
                texto += $", Páginas: {NumeroPaginas}.";
            Console.WriteLine(texto);
        }
    }
}