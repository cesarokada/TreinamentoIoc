using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoIoC.Interfaces;

namespace TreinamentoIoC.Implementacoes
{
    public class DataBaseMemoria : IDataBase
    {
        private List<Livro> livros;

        public DataBaseMemoria()
        {
            livros = new List<Livro>();
        }
        public void AdicionaLivro(Livro livro)
        {
            livros.Add(livro);
        }
        public Livro RetornaLivro(int versao)
        {
            return livros.FirstOrDefault(f => f.Versao == versao);
        }
    }
}
