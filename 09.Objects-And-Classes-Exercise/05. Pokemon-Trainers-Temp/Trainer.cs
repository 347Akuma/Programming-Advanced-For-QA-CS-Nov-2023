public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> PokemonCollection { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        PokemonCollection = new List<Pokemon>();
    }
}

