using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundPt2
{
    class Podcast
    {
        private List<Episodio> episodios = new();
        public string NomePodcast { get; }
        public string Host { get; }
        public int TotalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {NomePodcast} apresentado por {Host}\n");
            foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\n\nTotal de episódios: {TotalEpisodios}.");
        }
    }
}
