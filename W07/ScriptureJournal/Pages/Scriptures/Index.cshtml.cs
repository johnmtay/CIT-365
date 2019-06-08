using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Models.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Models.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }

        public async Task OnGetAsync(string scriptureBook, string searchString)
        {
            // Use LINQ to get book.
            IQueryable<string> bookQuery = from m in _context.Scripture
                                            orderby m.Book
                                            select m.Book;
            var scriptures = from m in _context.Scripture
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                scriptures = scriptures.Where(s => s.Passage.Contains(searchString) || s.Note.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(scriptureBook))
            {
                scriptures = scriptures.Where(x => x.Book == scriptureBook);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
        }
    }
}
