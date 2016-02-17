using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoIoC.Interfaces;

namespace TreinamentoIoC.Implementacoes
{
    public class LivroServico
    {
        private string Path = @"C:\Users\'\Documents\";
        private IDataBase database;

        public LivroServico(IDataBase database)
        {
            this.database = database;
        }

        public Livro PrimeiraVersao()
        {
            return database.RetornaLivro(1);
        }

        public void AdicionaLivro(Livro livro)
        {            
            File.AppendAllText(Path + livro.Nome + livro.Versao.ToString() + ".txt", livro.ToString() + "\n", System.Text.Encoding.UTF8);
            database.AdicionaLivro(livro);
        }

        public void AdicionaLivro()
        {
            var l = new Livro()
            {
                Nome = "TESTAN",
                Publicacao = DateTime.Now,
                Versao = 3
            };

            AdicionaLivro(l);
        }

        public void BuscaLivroArquivo(string NomeArquivo, int Versao)
        {
            string line;

            try
            { 
                StreamReader fp = new StreamReader(Path + NomeArquivo + Versao.ToString() + ".txt");

                line = fp.ReadLine();
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = fp.ReadLine();
                }
                fp.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
