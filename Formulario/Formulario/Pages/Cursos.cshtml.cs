using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Formulario
{
    public class CursosModel : PageModel
    {
        private readonly ILogger<CursosModel> _logger;

        public CursosModel(ILogger<CursosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}