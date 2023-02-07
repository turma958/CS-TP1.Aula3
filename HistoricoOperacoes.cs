using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TP1.Aula3
{
    public class HistoricoOperacoes
    {
        private Stack<string> _historico;
        public string NomeUsuario { get; private set; }

        public HistoricoOperacoes(string nomeUsuario)
        {
            NomeUsuario = nomeUsuario;

            _historico = new();
        }

        public void Adicionar(string operacao)
        {
            _historico.Push(operacao);
        }

        public void Desfazer()
        {
            Console.WriteLine($"Última operação desfeita.");
            _historico.Pop();
        }

        public string ExibeUltimaOperacao()
        {
            return _historico.Peek();
        }
    }
}
