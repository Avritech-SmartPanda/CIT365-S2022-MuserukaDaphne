using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages_Journal
{
    public class CreateModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public CreateModel(MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JournalEntry JournalEntry { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.JournalEntry == null || JournalEntry == null)
            {
                return Page();
            }

            _context.JournalEntry.Add(JournalEntry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
