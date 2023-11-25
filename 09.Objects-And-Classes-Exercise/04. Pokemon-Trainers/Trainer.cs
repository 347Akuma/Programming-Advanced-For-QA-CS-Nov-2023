internal class Trainer
{
    public string TrainerName { get; set; }
    public int NumberOfBadges { get; set; }
    public List<Pokemon> PokemonCollection { get; set; }

    public Trainer(string trainerName)
    {
        TrainerName = trainerName;
        NumberOfBadges = 0;
        PokemonCollection = new List<Pokemon>();
    }
}

