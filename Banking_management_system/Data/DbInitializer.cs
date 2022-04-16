using Banking_management_system.Models;
using System;
using System.Linq;

namespace Banking_management_system.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Banking_management_systemContext context)
        {
            context.Database.EnsureCreated();

            // Look for any movies.
            if (context.Client.Any())
            {
                return;   // DB has been seeded
            }
            var clients = new Client[]
            {
                    new Client{Name="Carson",Surname="Alexander",Email="2005-09-01"},
                    new Client{Name="Meredith",Surname="Alonso",Email="2002-09-01"},
                    new Client{Name="Arturo",Surname="Anand",Email="2003-09-01"},
            };

            foreach (Client s in clients)
            {
                context.Client.Add(s);
            }
            var banks = new Bank[]
            {
                    new Bank{ID=1050,Name="Chemistry",Percentage=3},
                    new Bank{ID=4022,Name="Microeconomics",Percentage=3},
                    new Bank{ID=4041,Name="Macroeconomics",Percentage=3},
            };

            foreach (Bank s in banks)
            {
                context.Bank.Add(s);
            }

            var balances = new Balance[]
            {
                    new Balance{ClientID=1, Name="first", Money = 0},
                    new Balance{ClientID=1,Name="second", Money = 0},
                    new Balance{ClientID=1,Name="third", Money = 0},
                    new Balance{ClientID=2,Name="fourth", Money = 0},
            };

            foreach (Balance e in balances)
            {
                context.Balance.Add(e);
            }

            context.SaveChanges();
        }
    }
}