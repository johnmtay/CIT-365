using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                // Look for scriptures.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Book of Mormon",
                        Reference = "1 Nephi 1:12",
                        Passage = "And it came to passthat as he read, he was filled with the Spirit of the Lord",
                        Note = "Reading the scriptures will fill us with the Spirit.",
                        DateAdded = DateTime.Parse("2019-6-6")
                    },

                    new Scripture
                    {
                        Book = "Bible",
                        Reference = "Matthew 5:14",
                        Passage = "Ye are the light of the world. A city that is set on an hill cannnot be hid.",
                        Note = "We are the light of the world.",
                        DateAdded = DateTime.Parse("2019-6-6")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
