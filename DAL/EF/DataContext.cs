using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class DataContext : DbContext
    {
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Reserv> Reserves { get; set; }

        static DataContext()
        {
            Database.SetInitializer<DataContext>(new QuestDbInitializer());
        }

        public DataContext(string connectionString) : base(connectionString) { }
    }

    public class QuestDbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            db.Quests.Add(new Quest { Name = "MadMax", Description = "MadMax description", Duration = 3, PlayersLimit = 12, Price = 600 });
            db.Quests.Add(new Quest { Name = "New York", Description = "New York description", Duration = 2, PlayersLimit = 10, Price = 400 });
            db.Quests.Add(new Quest { Name = "Integration", Description = "Integration description", Duration = 2, PlayersLimit = 4, Price = 550 });
            db.Quests.Add(new Quest { Name = "Son of Sam", Description = "Son of Sam description", Duration = 2, PlayersLimit = 10, Price = 500 });
            db.Quests.Add(new Quest { Name = "Deprecated", Description = "Deprecated description", Duration = 2, PlayersLimit = 8, Price = 210 });
            db.Quests.Add(new Quest { Name = "Last of us", Description = "Last of us description", Duration = 1, PlayersLimit = 8, Price = 200 });
            db.Quests.Add(new Quest { Name = "Injection", Description = "Injection description", Duration = 3, PlayersLimit = 12, Price = 600 });
            db.Quests.Add(new Quest { Name = "All inclusive", Description = "All inclusive description", Duration = 2, PlayersLimit = 10, Price = 400 });
            db.Quests.Add(new Quest { Name = "Just one minute", Description = "Just one minute description", Duration = 2, PlayersLimit = 4, Price = 550 });
            db.Quests.Add(new Quest { Name = "Mirror hole", Description = "Mirror hole description", Duration = 2, PlayersLimit = 10, Price = 500 });
            db.Quests.Add(new Quest { Name = "Smoothering black", Description = "Smoothering black description", Duration = 2, PlayersLimit = 8, Price = 210 });
            db.Quests.Add(new Quest { Name = "Find yourself", Description = "Find yourself description", Duration = 1, PlayersLimit = 8, Price = 200 });

            db.SaveChanges();
        }
    }
}
