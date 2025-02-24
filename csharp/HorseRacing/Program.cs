namespace HorseRacing
{
	class Program
	{
		const int NumberOfHorses = 5;
		const int DistanceToCover = 30;
		static readonly Random random = new();

		static async Task Main()
		{
			Console.WriteLine("Welcome to the Horse Racing System!");
			Console.WriteLine("Race starts now!");

			List<Task<int>> horseTasks = [];
			for (int i = 1; i <= NumberOfHorses; i++)
			{
				int horseNumber = i;
				horseTasks.Add(Task.Run(() => RunRace(horseNumber)));
			}

			int[] results = await Task.WhenAll(horseTasks);
			int winningHorse = Array.IndexOf(results, DistanceToCover) + 1;

			Console.WriteLine("Race finished!");
			Console.WriteLine($"Horse {winningHorse} wins the race!");
		}

		static int RunRace(int horseNumber)
		{
			int distanceCovered = 0;
			while (distanceCovered < DistanceToCover)
			{
				int step = random.Next(1, 4);
				distanceCovered += step;
				Console.WriteLine($"Horse {horseNumber}: Distance covered: {distanceCovered}");
				Thread.Sleep(500);
			}
			return distanceCovered;
		}
	}
}