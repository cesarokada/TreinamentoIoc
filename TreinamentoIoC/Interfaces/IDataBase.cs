using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoIoC.Implementacoes;

namespace TreinamentoIoC.Interfaces
{
    public interface IDataBase
    {
        Livro RetornaLivro(int versao);

        void AdicionaLivro(Livro livro);
    }
}
