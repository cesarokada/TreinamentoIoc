using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoIoC.Implementacoes;
using TreinamentoIoC.Interfaces;

namespace TreinamentoIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StandardKernel kernel = new Ninject.StandardKernel())
            {
                kernel.Bind<IDataBase>()
                    .To<DataBaseMemoria>();

                var s = kernel.Get<LivroServico>();
                s.AdicionaLivro();
                s.BuscaLivroArquivo("TESTAN",3);
                Livro l = s.PrimeiraVersao();
            }

            Console.ReadKey();
        }
    }
}
