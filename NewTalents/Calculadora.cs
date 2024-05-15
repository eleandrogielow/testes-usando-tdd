using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
/* A primeira regra do TDD é, iniciar um teste falho, no caso, utilizando um return nulo, ou não correto. 
Para seguir o método TDD, deve seguir as regras de negócio, criando os testes mas não implementando-os.
Se inicia a classe de calculos (somar, subtrair, multiplicas, dividir) com um valor padrão apenas.
A outra regra de negócio pede para retornar um histórico, para isso, cria-se uma lista vazia
*/
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        /* 
        Cada vez que chamar o método somar, subtrair, multiplicar, dividir é inserido no começo da lista
        seu respectivo calculo, assim formando o historico de calculos solicitados.
        Como é um código simples, pode-se repetir o método para cada calculo, mas se fosse um histórico
        com um pouco mais de instruções, caberia fazer um método a parte, como boa prática.
        */
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;

            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
            // ou: return val1 + val2;
        }
        public int subtrair(int val1, int val2)
        {
           int res = val1 - val2;
           listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHistorico.Insert(0, "Resultado: " + res + " - data: " + data);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}