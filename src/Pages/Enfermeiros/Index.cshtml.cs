using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModeloCeub.Interfaces.Services;
using ModeloCeub.Models;

namespace ModeloCeub.Pages.Enfermeiros
{

    public class IndexModel : PageModel
    {
        private readonly IEnfermeiroService _enfermeiroService;

        public IndexModel(IEnfermeiroService enfermeiroService)
        {
            _enfermeiroService = enfermeiroService;
        }

        [BindProperty]
        public IEnumerable<Enfermeiro> Enfermeiros { get; set; }


        [BindProperty]
        public Enfermeiro Enfermeiro { get; set; }

        public async Task OnGetAsync()
        {
            await MontarPagina();
        }

        public async Task MontarPagina()
        {
            Enfermeiros = await _enfermeiroService.ObterTodos("Usuario");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _enfermeiroService.Adicionar(Enfermeiro);
            }

            await MontarPagina();
            return Page();
        }
    }
}