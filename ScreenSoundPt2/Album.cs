using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSoundPt2
{
    class Album
    {
        public Album(string nome)
        {
            Nome = nome;
        }

        private List<Musica> musicas = new List<Musica>();
        public string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao); 
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de Musica do album {Nome}:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.NomeMusica}");
            }
            Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
        }
    }
}
