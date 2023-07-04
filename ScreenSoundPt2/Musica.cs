using ScreenSoundPt2;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        NomeMusica = nome;
    }
    
    public string NomeMusica { get; set; }
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
     $"A música {NomeMusica} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {NomeMusica}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}


