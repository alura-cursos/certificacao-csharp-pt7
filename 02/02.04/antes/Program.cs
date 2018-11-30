using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Diretor> diretores = GetDiretores();
            List<Filme> filmes = GetFilmes();

            Console.ReadKey();
        }

        private static void Imprimir(IEnumerable<Filme> filmes)
        {
            Console.WriteLine($"{"Título",-40}{"Diretor",-20}{"Ano",4}");
            Console.WriteLine(new string('=', 64));
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Titulo,-40}{filme.Diretor.Nome,-20}{filme.Ano}");
            }
            Console.WriteLine();
        }

        private static void Imprimir(IEnumerable<FilmeResumido> filmes)
        {
            Console.WriteLine($"{"Título",-40}{"Diretor",-20}");
            Console.WriteLine(new string('=', 60));
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Titulo,-40}{filme.NomeDiretor,-20}");
            }
            Console.WriteLine();
        }

        private static List<Diretor> GetDiretores()
        {
            return new List<Diretor>
            {
                new Diretor { Id = 1, Nome = "Quentin Tarantino" },
                new Diretor { Id = 2, Nome = "James Cameron" },
                new Diretor { Id = 3, Nome = "Tim Burton" }
            };
        }

        private static List<Filme> GetFilmes()
        {
            return new List<Filme> {
                new Filme {
                    DiretorId = 1,
                    Diretor = new Diretor { Nome = "Quentin Tarantino" },
                    Titulo = "Pulp Fiction",
                    Ano = 1994,
                    Minutos = 2 * 60 + 34
                },
                new Filme {
                    DiretorId = 1,
                    Diretor = new Diretor { Nome = "Quentin Tarantino" },
                    Titulo = "Django Livre",
                    Ano = 2012,
                    Minutos = 2 * 60 + 45
                },
                new Filme {
                    DiretorId = 1,
                    Diretor = new Diretor { Nome = "Quentin Tarantino" },
                    Titulo = "Kill Bill Volume 1",
                    Ano = 2003,
                    Minutos = 1 * 60 + 51
                },

                new Filme {
                    DiretorId = 2,
                    Diretor = new Diretor { Nome = "James Cameron" },
                    Titulo = "Avatar",
                    Ano = 2009,
                    Minutos = 2 * 60 + 42
                },
                new Filme {
                    DiretorId = 2,
                    Diretor = new Diretor { Nome = "James Cameron" },
                    Titulo = "Titanic",
                    Ano = 1997,
                    Minutos = 3 * 60 + 14
                },
                new Filme {
                    DiretorId = 2,
                    Diretor = new Diretor { Nome = "James Cameron" },
                    Titulo = "O Exterminador do Futuro",
                    Ano = 1984,
                    Minutos = 1 * 60 + 47
                },

                new Filme {
                    DiretorId = 3,
                    Diretor = new Diretor { Nome = "Tim Burton" },
                    Titulo = "O Estranho Mundo de Jack",
                    Ano = 1993,
                    Minutos = 1 * 60 + 16
                },
                new Filme {
                    DiretorId = 3,
                    Diretor = new Diretor { Nome = "Tim Burton" },
                    Titulo = "Alice no País das Maravilhas",
                    Ano = 2010,
                    Minutos = 1 * 60 + 48
                },
                new Filme {
                    DiretorId = 3,
                    Diretor = new Diretor { Nome = "Tim Burton" },
                    Titulo = "A Noiva Cadáver",
                    Ano = 2005,
                    Minutos = 1 * 60 + 17
                }
            };
        }
    }

    class Diretor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    class Filme
    {
        public int DiretorId { get; set; }
        public Diretor Diretor { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public int Minutos { get; set; }
    }

    class FilmeResumido
    {
        public string NomeDiretor { get; set; }
        public string Titulo { get; set; }
    }
}
