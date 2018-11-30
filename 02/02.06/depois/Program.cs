using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlText =
            "<Filmes>" +
                "<Filme>" +
                    "<Diretor>Quentin Tarantino</Diretor>" +
                    "<Titulo>Pulp Fiction</Titulo>" +
                    "<Minutos>154</Minutos>" +
                "</Filme>" +
                "<Filme>" +
                    "<Diretor>James Cameron</Diretor>" +
                    "<Titulo>Avatar</Titulo>" +
                    "<Minutos>162</Minutos>" +
                "</Filme>" +
            "</Filmes>";

            XDocument documentoFilmes = XDocument.Parse(xmlText);

            IEnumerable<XElement> filmesSelecionados2 =
            from filme in documentoFilmes.Descendants("Filme")
            select filme;
            foreach (XElement item in filmesSelecionados2)
            {
                Console.WriteLine("Diretor: {0}, Título: {1} ",
                    item.Element("Diretor").FirstNode,
                    item.Element("Titulo").FirstNode);
            }
            Console.WriteLine();


            filmesSelecionados2 =
            from filme in documentoFilmes.Descendants("Filme")
            where (string)filme.Element("Diretor") == "Quentin Tarantino"
            select filme;
            foreach (XElement item in filmesSelecionados2)
            {
                Console.WriteLine("Diretor: {0}, Título: {1} ",
                    item.Element("Diretor").FirstNode,
                    item.Element("Titulo").FirstNode);
            }
            Console.WriteLine();


            filmesSelecionados2 =
            from filme in documentoFilmes.Descendants("Filme")
            .Where(elemento => (string)elemento.Element("Diretor")
                == "Quentin Tarantino")
            select filme;
            foreach (XElement item in filmesSelecionados2)
            {
                Console.WriteLine("Diretor: {0}, Título: {1} ",
                    item.Element("Diretor").FirstNode,
                    item.Element("Titulo").FirstNode);
            }
            Console.WriteLine();

            XElement filmesXML = new XElement("Filmes",
                new List<XElement>
                {
                    new XElement ("Filme" ,
                        new XElement ("Diretor" , "Steven Spielberg"),
                        new XElement ("Titulo" , "A Lista de Schindler")),
                    new XElement ("Filme",
                        new XElement ("Diretor" , "Christopher Nolan"),
                        new XElement ("Titulo" , "Batman: O Cavaleiro das Trevas"))
                }
            );




            filmesSelecionados2 =
            from filme in documentoFilmes.Descendants("Filme")
            select filme;
            foreach (XElement item in filmesSelecionados2)
            {
                item.Element("Titulo").FirstNode.ReplaceWith("Novo filme");
            }

            foreach (XElement item in filmesSelecionados2)
            {
                Console.WriteLine("Diretor: {0}, Título: {1} ",
                    item.Element("Diretor").FirstNode,
                    item.Element("Titulo").FirstNode);
            }
            Console.WriteLine();



            var filmesSelecionados3 =
            from filme in documentoFilmes.Descendants("Filme")
            select filme;
            foreach (XElement item in filmesSelecionados3)
            {
                item.Add(new XElement("Genero", "Drama"));
            }

            foreach (XElement item in filmesSelecionados3)
            {
                Console.WriteLine("Diretor: {0}, Título: {1}, Gênero: {2} ",
                    item.Element("Diretor").FirstNode,
                    item.Element("Titulo").FirstNode,
                    item.Element("Genero").FirstNode);
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
