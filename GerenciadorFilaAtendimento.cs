using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TP1.Aula3
{
    public class GerenciadorFilaAtendimento
    {
        private Queue<int> _filaAtendimento;
        private int _proximaSenha = 1;

        public GerenciadorFilaAtendimento()
        {
            _filaAtendimento = new();
        }

        public int GerarSenha()
        {
            _filaAtendimento.Enqueue(_proximaSenha);

            Console.WriteLine("Senha gerada com sucesso");

            return _proximaSenha++;
        }

        public void ChamarProximo()
        {
            var proximo = _filaAtendimento.Dequeue();

            Console.WriteLine($"Próxima senha: {proximo}");
        }

        public void MostrarFila()
        {
            Console.WriteLine("Senhas da fila: ");

            foreach(int senha in _filaAtendimento)
            {
                Console.Write($"{senha} ");
            }

            Console.WriteLine();
        }

        public void LimparFila()
        {
            _filaAtendimento.Clear();
        }
    }
}
