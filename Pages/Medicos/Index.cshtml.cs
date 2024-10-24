using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModeloCeub.Interfaces.Services;
using ModeloCeub.Models;

namespace ModeloCeub.Pages.Medicos
{

    public class IndexModel : PageModel
    {
        private readonly IMedicoService _medicoService;

        public IndexModel(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [BindProperty]
        public IEnumerable<Medico> Medicos { get; set; }

        [BindProperty]
        public Medico Medico { get; set; }


        public async Task OnGetAsync()
        {
            await MontarPagina();
        }

        public async Task MontarPagina()
        {

            Medicos = await _medicoService.ObterTodos("Usuario");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _medicoService.Adicionar(Medico);
            }

            await MontarPagina();
            return Page();
        }
    }
}