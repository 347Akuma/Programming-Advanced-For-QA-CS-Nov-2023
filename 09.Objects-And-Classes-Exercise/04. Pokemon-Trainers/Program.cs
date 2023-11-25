﻿Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

string input;
while ((input = Console.ReadLine()) != "Tournament")
{
    string[] command = input.Split();

    string trainerName = command[0];
    string pokemonName = command[1];
    string pokemonElement = command[2];
    int pokemonHealth = int.Parse(command[3]);

    if (!trainers.ContainsKey(trainerName))
    {
        Trainer trainer = new Trainer(trainerName);
        trainers.Add(trainerName, trainer);
    }

    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
    trainers[trainerName].PokemonCollection.Add(pokemon);

}

while ((input = Console.ReadLine()) != "End")
{
    if (input == "Fire" || input == "Water" || input == "Electricity")
    {
        foreach (var trainer in trainers.Values)
        {
            bool elementFound = trainer.PokemonCollection.Any(p => p.Element == input);

            if (elementFound)
            {
                trainer.NumberOfBadges++;
            }
            else
            {
                foreach (var pokemon in trainer.PokemonCollection)
                {
                    pokemon.Health -= 10;
                }
                trainer.PokemonCollection.RemoveAll(p => p.Health <= 0);
            }
        }
    }
}

var sortedTrainers = trainers.Values.OrderByDescending(p => p.NumberOfBadges);
foreach (var trainer in sortedTrainers)
{
    Console.WriteLine($"{trainer.TrainerName} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
}

