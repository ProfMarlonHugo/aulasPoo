using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instancia de um objeto*/
            Time objTime = new Time();
            objTime.nome = "Palmeiras";
            objTime.comprarJogador(1);

            /*Mostrar valor para o usuário*/
            System.Console.Write(@"Entre com a cidade do time "+ objTime.nome + ": ");
            /*Ler entrada do usuário*/
            objTime.cidade = System.Console.ReadLine();

            /*Mostrar valor para o usuário*/
            System.Console.Write(@"Entre com o estado da cidade " + objTime.cidade+ ": ");
            /*Ler entrada do usuário*/
            objTime.estado = System.Console.ReadLine();

            /*Mostrar valor para o usuário*/
            System.Console.Write(@"Entre com o país do estado " + objTime.estado+ ": ");
            /*Ler entrada do usuário*/
            objTime.pais = System.Console.ReadLine();

            /*Mostrar valor para o usuário*/
            System.Console.Write(@"Entre com o número de jogadores do time " + objTime.nome + ": ");
            /*Ler entrada do usuário*/
            objTime.numeroDeJogadores = Convert.ToInt32(System.Console.ReadLine());
            
            /*Mostrar valor para o usuário*/
            System.Console.Write(@"Entre com o valor do time " + objTime.nome + ": R$");
            /*Ler entrada do usuário*/
            objTime.valorDoTimeEmDinheiro = Convert.ToInt32(System.Console.ReadLine());

            /*Mostrar stado do meu objeto*/
            string statusDoObjeto;
            statusDoObjeto = objTime.statusClass();
            System.Console.WriteLine(statusDoObjeto);

            /*Parar o programa*/
            System.Console.ReadKey();

        }
    }
}
