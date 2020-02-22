
namespace ProjetoTime
{
    class Time
    {
        /*Atributos (Características da Classe)*/
        public string nome;
        public string pais;
        public string estado;
        public string cidade;
        public int numeroDeJogadores = 0;
        public int numeroDeTitulos = 0;
        public double valorDoTimeEmDinheiro = 0;

        /*Métodos */
        public void comprarJogador(int numJongador)
        {
            this.numeroDeJogadores += numJongador;
        }

        public string statusClass()
        {
            string retorno;
            retorno = "\nNome: "+this.nome +
                "\nCidade: "+this.cidade + 
                "\nEstado: "+this.estado +
                "\nNúmero de Jogadores: "+this.numeroDeJogadores +
                "\nNúmero de Títulos: "+this.numeroDeTitulos +
                "\nValor do time: R$"+this.valorDoTimeEmDinheiro;

            return retorno;
        }

    }
}
