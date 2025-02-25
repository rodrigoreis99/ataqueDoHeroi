namespace ataqueDoHeroi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var heroi1 = new Heroi("Arthas", 30, "guerreiro");
            var heroi2 = new Heroi("Merlin", 150, "mago");
            var heroi3 = new Heroi("Shen", 25, "ninja");
            var heroi4 = new Heroi("Bruce", 40, "monge");

            heroi1.ExibirInformacoes();
            heroi1.Atacar();

            heroi2.ExibirInformacoes();
            heroi2.Atacar();

            heroi3.ExibirInformacoes();
            heroi3.Atacar();

            heroi4.ExibirInformacoes();
            heroi4.Atacar();
        }
    }
}
