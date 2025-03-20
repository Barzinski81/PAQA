namespace _04.PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] splitInput = input.Split();

                string trainerName = splitInput[0];
                string pokemonName = splitInput[1];
                string pokemonElement = splitInput[2];
                int pokemonHealth = int.Parse(splitInput[3]);

                if (trainers.Any(t => t.Name == trainerName))
                {
                    Trainer existingTrainer = trainers.First(t => t.Name == trainerName);
                    Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    existingTrainer.Pokemons.Add(currentPokemon);
                }

                else
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    newTrainer.Pokemons.Add(currentPokemon);
                    trainers.Add(newTrainer);
                }

                input = Console.ReadLine();

            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if(trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.NumberOfBadges ++;
                    }

                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);

                        trainer.Pokemons.RemoveAll(p => p.Health  <= 0);
                    }
                }

                element = Console.ReadLine();

            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
