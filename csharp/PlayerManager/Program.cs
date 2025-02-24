namespace PlayerManager
{

	enum MenuChoice
	{
		AddPlayer = 1,
		RemovePlayer,
		SearchPlayer,
		DisplayAllPlayers,
		Exit
	}

	class Program
	{
		private static readonly string WelcomeMessage = "Welcome to the Soccer Player Management System!\n";
		private static readonly string InvalidOptionMessage = "\nInvalid option. Please try again.\n";

		static void Main()
		{
			var playerManager = new PlayerManager();
			Console.Write(WelcomeMessage);
			int choice;
			do
			{
				Console.Write("\nMenu:\n1. Add a player\n2. Remove a player\n3. Search for a player\n4. Display all players\n5. Exit\nEnter your choice: ");
				choice = ReadMenuChoice();

				try
				{
					switch ((MenuChoice)choice)
					{
						case MenuChoice.AddPlayer:
							playerManager.AddPlayer();
							break;
						case MenuChoice.RemovePlayer:
							playerManager.RemovePlayer();
							break;
						case MenuChoice.SearchPlayer:
							playerManager.SearchPlayer();
							break;
						case MenuChoice.DisplayAllPlayers:
							playerManager.DisplayAllPlayers();
							break;
						case MenuChoice.Exit:
							PlayerManager.Exit();
							break;
						default:
							Console.Write(InvalidOptionMessage);
							break;
					}
				}
				catch (Exception ex)
				{
					Console.Write($"An error occurred: {ex.Message}");
				}
			} while (choice != (int)MenuChoice.Exit);
		}

		private static int ReadMenuChoice()
		{
			if (!int.TryParse(Console.ReadLine(), out int choice))
				throw new FormatException("Invalid menu choice.");

			return choice;
		}
	}

	class PlayerManager
	{
		private readonly List<Player> players = [];

		public void AddPlayer()
		{
			Console.Write("\nEnter player details:\nName: ");
			string? name = Console.ReadLine();
			Console.Write("Age: ");
			int age = ReadAge();
			Console.Write("Position: ");
			string? position = Console.ReadLine();

			players.Add(new Player { Name = name, Age = age, Position = position });
			Console.Write("Player added successfully!\n");
		}

		private static int ReadAge()
		{
			int age;
			string? input;
			do
			{
				input = Console.ReadLine();
			} while (!int.TryParse(input, out age) || age < 0);

			return age;
		}

		public void RemovePlayer()
		{
			Console.Write("\nEnter the name of the player to remove: ");
			string? name = Console.ReadLine();
			Player? playerToRemove = players.Find(p => p.Name?.Equals(name, StringComparison.OrdinalIgnoreCase) == true);

			if (playerToRemove != null)
			{
				players.Remove(playerToRemove);
				Console.Write("Player removed successfully!\n");
			}
			else
			{
				Console.Write("Player not found.\n");
			}
		}

		public void SearchPlayer()
		{
			Console.Write("\nEnter the name of the player to search: ");
			string? name = Console.ReadLine();
			Player? playerToSearch = players.Find(p => p.Name?.Equals(name, StringComparison.OrdinalIgnoreCase) == true);

			if (playerToSearch != null)
			{
				DisplayPlayer(playerToSearch);
			}
			else
			{
				Console.Write("Player not found.\n");
			}
		}

		public void DisplayAllPlayers()
		{
			if (players.Count > 0)
			{
				Console.Write("\nList of players:\n");
				foreach (Player player in players)
					DisplayPlayer(player);

				Console.WriteLine();
			}
			else
			{
				Console.Write("No players to display.\n");
			}
		}

		private static void DisplayPlayer(Player player) => Console.Write($"Name: {player.Name}, Age: {player.Age}, Position: {player.Position}\n");

		public static void Exit() => Console.Write("\nThank you for using Soccer Player Management System.\n");

	}

	class Player
	{
		public string? Name { get; set; }
		public int Age { get; set; }
		public string? Position { get; set; }
	}
}