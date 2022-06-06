using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context == null || context.JournalEntry == null)
                {
                    throw new ArgumentNullException("Null MyScriptureJournalContext");
                }
                // Look for any movies.
                if (context.JournalEntry.Any())
                {
                    return;   // DB has been seeded
                }

                context.JournalEntry.AddRange(
                    new JournalEntry
                    {
                        Title = "Ten Commandments",
                        EntryDate = DateTime.Parse("2022-06-04"),
                        Book = "Genesis",
                        Reference = "20: 3-17",
                        Notes = "The Ten Commandments are pretty great."
                    },

                    new JournalEntry
                    {
                        Title = "Sacrament Prayers",
                        EntryDate = DateTime.Parse("2022-06-02"),
                        Book = "Doctrine and Covenants",
                        Reference = "20: 77,79",
                        Notes = "Bread and water to remember Christ's atoning sacrifice."
                    },

                    new JournalEntry
                    {
                        Title = "Don't procrastinate",
                        EntryDate = DateTime.Parse("2022-06-01"),
                        Book = "Alma",
                        Reference = "34: 32-34",
                        Notes = "Prepare now."
                    },

                    new JournalEntry
                    {
                        Title = "Be like this",
                        EntryDate = DateTime.Parse("2022-06-03"),
                        Book = "Alma",
                        Reference = "7: 23-24",
                        Notes = "This is a great list of qualities to pursue. Imagine if everyone in the world were like this. There would be no war, no poor, no inequality. There would be peace."
                    }
                    
                
                );
                context.SaveChanges();
            }
        }
    }
}
