using System;
using System.Collections.Generic;
using System.Linq;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VotingSystem system = new VotingSystem();
            system.Run();
        }
    }

    class VotingSystem
    {
        private List<User> users = new List<User>();

        private Dictionary<string, int> votes = new Dictionary<string, int>()
        {
            { "Film", 0 },
            { "Tech Stack", 0 },
            { "Spor", 0 }
        };

        private string[] categories = { "Film", "Tech Stack", "Spor" };

        public void Run()
        {
            Console.WriteLine("=== VOTING SYSTEM ===");

            while (true)
            {
                Console.WriteLine("\nUsername giriniz:");
                string username = Console.ReadLine();

                User user = GetOrCreateUser(username);

                Console.WriteLine($"\nHoş geldin {user.Username}!");

                Vote(user);

                Console.WriteLine("\nDevam etmek istiyor musun? (y/n)");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                    break;
            }

            ShowResults();
        }

        private User GetOrCreateUser(string username)
        {
            var user = users.FirstOrDefault(x => x.Username == username);

            if (user == null)
            {
                Console.WriteLine("Kullanıcı bulunamadı. Yeni kayıt oluşturuldu.");
                user = new User { Username = username };
                users.Add(user);
            }

            return user;
        }

        private void Vote(User user)
        {
            Console.WriteLine("\nKategoriler:");
            for (int i = 0; i < categories.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i]}");
            }

            Console.Write("\nLütfen oy vermek istediğiniz kategori numarasını giriniz: ");
            int choice = int.Parse(Console.ReadLine());

            string selectedCategory = categories[choice - 1];
            votes[selectedCategory]++;

            Console.WriteLine($"Oy {selectedCategory} kategorisine verildi.");
        }

        private void ShowResults()
        {
            Console.WriteLine("\n=== VOTING RESULTS ===");

            int totalVotes = votes.Values.Sum();

            if (totalVotes == 0)
            {
                Console.WriteLine("Henüz oy kullanılmadı.");
                return;
            }

            foreach (var vote in votes)
            {
                double percent = (double)vote.Value / totalVotes * 100;

                Console.WriteLine($"{vote.Key}: {vote.Value} oy - %{percent:F2}");
            }
        }
    }

    class User
    {
        public string Username { get; set; }
    }
}
