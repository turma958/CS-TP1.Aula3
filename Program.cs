namespace CS_TP1.Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            //var historicoOperacoes = new HistoricoOperacoes("Joel");

            //historicoOperacoes.Adicionar("Tirar o grosso");
            //historicoOperacoes.Adicionar("Passar uma água de leve");
            //historicoOperacoes.Adicionar("Ensaboar o utencílio");

            //historicoOperacoes.Desfazer();

            //var ultimaOp = historicoOperacoes.ExibeUltimaOperacao();

            //Console.WriteLine($"A última operação realizada foi: {ultimaOp}");            

            ////var p1 = new Stack<int>(new List<int> { 1,2,2,3});
            #endregion

            #region Queue

            //var gerenciadorFilaAtendimento = new GerenciadorFilaAtendimento();

            //gerenciadorFilaAtendimento.GerarSenha();
            //gerenciadorFilaAtendimento.GerarSenha();
            //gerenciadorFilaAtendimento.GerarSenha();
            //gerenciadorFilaAtendimento.GerarSenha();

            //gerenciadorFilaAtendimento.MostrarFila();

            //gerenciadorFilaAtendimento.ChamarProximo();
            //gerenciadorFilaAtendimento.ChamarProximo();
            //gerenciadorFilaAtendimento.ChamarProximo();

            //gerenciadorFilaAtendimento.MostrarFila();

            //gerenciadorFilaAtendimento.GerarSenha();

            //gerenciadorFilaAtendimento.ChamarProximo();

            //gerenciadorFilaAtendimento.MostrarFila();

            #endregion

            #region Dictionary

            Dictionary<int, string> dict = new Dictionary<int, string>();
            //Dictionary<int, string> dict = new Dictionary<int, string>() 
            //{ 
            //    {1, "Maria" }, 
            //    {2, "Paulo" } 
            //};           
            
            //Adicionando elementos
            dict.Add(111, "Maria");
            dict.Add(22, "Paulo");
            dict.Add(3, "Pedro");


            //Acessando elementos
            //foreach (KeyValuePair<int, string> item in dict)
            //{
            //    Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
            //}

            //foreach ((int k, string v) in dict)
            //{
            //    Console.WriteLine("chave: {0}, valor: {1}", k, v);
            //}

            //foreach (var item in dict)
            //{
            //    Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
            //}

            //for (int i = 0; i < dict.Count; i++)
            //{
            //    Console.WriteLine("chave: {0}, valor: {1}", dict.Keys.ElementAt(i), dict.Values.ElementAt(i));
            //}

            //Console.WriteLine(dict[2]);
            //Console.WriteLine(dict[3]);

            //string resultado;
            //if(dict.TryGetValue(0, out resultado))
            //{
            //    Console.WriteLine(resultado);
            //}
            //else
            //{
            //    Console.WriteLine("Não foi possível achar a chave especificada");
            //}

            //var contem = dict.Contains(new KeyValuePair<int, string>(3, "p"));
            //var contem = dict.ContainsKey(9);
            //var contem = dict.ContainsValue("Paulo");

            //Console.WriteLine(contem);

            //dict.Remove(2);

            //foreach (var item in dict)
            //{
            //    Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
            //}

            SortedDictionary<int, string> dict2 = new SortedDictionary<int, string>();

            dict2.Add(111, "Maria");
            dict2.Add(22, "Paulo");
            dict2.Add(3, "Pedro");

            foreach (var item in dict2)
            {
                Console.WriteLine("chave: {0}, valor: {1}", item.Key, item.Value);
            }

            Dictionary<HistoricoOperacoes, GerenciadorFilaAtendimento> dict3 = new Dictionary<HistoricoOperacoes, GerenciadorFilaAtendimento>();

            Dictionary<int, (string, string)> dict4 = new Dictionary<int, (string, string)>();

            #endregion

            Console.ReadLine();
        }
    }
}