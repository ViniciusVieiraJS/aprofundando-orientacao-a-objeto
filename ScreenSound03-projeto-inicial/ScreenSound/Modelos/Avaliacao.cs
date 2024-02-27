
namespace ScreenSound.Modelos;

    internal class Avaliacao
    {
        public int Nota { get; }
        public Avaliacao(int nota)
        {
            Nota = nota;
        }
    // Nesta aula introduzimos uma nova classe Avaliacao para que ela pudesse isolar
    // tanto o dado primitivo com o valor da nota (usamos um inteiro para representá-la)
    // quanto possíveis comportamentos do conceito de avaliação em nossa aplicação
    // (por exemplo a capacidade de transformar um texto em um objeto através do método estático Parse()
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
    }
