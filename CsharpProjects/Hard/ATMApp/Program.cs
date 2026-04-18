using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.Run();
        }
    }

    class ATM
    {
        private Dictionary<string, decimal> accounts = new Dictionary<string, decimal>()
        {
            { "hazal", 1000 },
            { "admin", 5000 }
        };

        private List<string> transactionLog = new List<string>();
        private List<string> fraudLog = new List<string>();

        private string logPath = $"EOD_{DateTime.Now:ddMMyyyy}.txt";

        public void Run()
        {
            Console.WriteLine("=== ATM SYSTEM ===");

            string user = Login();

            if (user == null)
            {
                Console.WriteLine("3 hatalı giriş. Sistem kilitlendi.");
                return;
            }

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1- Para Çekme");
                Console.WriteLine("2- Para Yatırma");
                Console.WriteLine("3- Ödeme Yapma");
                Console.WriteLine("4- Gün Sonu (EOD)");
                Console.WriteLine("5- Çıkış");

                Console.Write("Seçim: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Withdraw(user);
                        break;
                    case "2":
                        Deposit(user);
                        break;
                    case "3":
                        Payment(user);
                        break;
                    case "4":
                        EndOfDay();
                        break;
                    case "5":
                        exit = true;
                        break;
                }
            }
        }

        private string Login()
        {
            int attempt = 0;

            while (attempt < 3)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();

                if (accounts.ContainsKey(username))
                {
                    transactionLog.Add($"LOGIN SUCCESS: {username} - {DateTime.Now}");
                    return username;
                }
                else
                {
                    fraudLog.Add($"LOGIN FAIL: {username} - {DateTime.Now}");
                    attempt++;
                }
            }

            return null;
        }

        private void Withdraw(string user)
        {
            Console.Write("Çekilecek tutar: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (accounts[user] >= amount)
            {
                accounts[user] -= amount;
                transactionLog.Add($"{user} WITHDRAW {amount} - {DateTime.Now}");
                Console.WriteLine("İşlem başarılı.");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
        }

        private void Deposit(string user)
        {
            Console.Write("Yatırılacak tutar: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            accounts[user] += amount;
            transactionLog.Add($"{user} DEPOSIT {amount} - {DateTime.Now}");
            Console.WriteLine("İşlem başarılı.");
        }

        private void Payment(string user)
        {
            Console.Write("Ödeme tutarı: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            accounts[user] -= amount;
            transactionLog.Add($"{user} PAYMENT {amount} - {DateTime.Now}");
            Console.WriteLine("Ödeme yapıldı.");
        }

        private void EndOfDay()
        {
            Console.WriteLine("\n=== END OF DAY REPORT ===");

            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine("=== TRANSACTIONS ===");

                foreach (var t in transactionLog)
                {
                    writer.WriteLine(t);
                }

                writer.WriteLine("\n=== FRAUD LOG ===");

                foreach (var f in fraudLog)
                {
                    writer.WriteLine(f);
                }
            }

            Console.WriteLine($"Rapor dosyaya yazıldı: {logPath}");

            ShowFile();
        }

        private void ShowFile()
        {
            Console.WriteLine("\n--- FILE CONTENT ---");

            if (File.Exists(logPath))
            {
                string content = File.ReadAllText(logPath);
                Console.WriteLine(content);
            }
        }
    }
}
